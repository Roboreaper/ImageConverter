using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;

namespace ImageConverter
{
    public class ImageTools
    {
        public static void ConvertFromFile(string backup, string path, Action<string> errorMessage)
        {        
            if (System.IO.File.Exists(path))
            {
                var ext = System.IO.Path.GetExtension(path);
                if (ext.Equals(".pptx", StringComparison.InvariantCultureIgnoreCase) || ext.Equals(".ppt", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (path.Contains("~$"))
                        return; // ignore this file

                    // load and convert ppt
                    {
                        Microsoft.Office.Interop.PowerPoint.Application pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();
                        Presentation pptPresentation = null;
                        try
                        {
                            errorMessage($"Converting powerpoint: {path}");
                            pptPresentation = pptApplication.Presentations.Open(path, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

                            var dir = Path.GetDirectoryName(path);

                            int i = 0;
                            foreach (Slide item in pptPresentation.Slides)
                            {
                                i++;
                                errorMessage($"Converting Slide {i}");

                                var temp = Path.Combine(dir, $"temp{ Number2String(i)}.png");
                                try
                                {
                                    item.Export(temp, "png");
                                }
                                catch (Exception Ex)
                                {
                                    errorMessage($"Could not convert slide {i}");
                                    System.Diagnostics.Trace.TraceError(Ex.Message);
                                    continue;
                                }

                                if (!File.Exists(temp))
                                {
                                    errorMessage($"Could not read slide {i}");
                                    continue;
                                }

                                Bitmap negated = null;
                                try
                                {
                                    using (var im = Image.FromFile(temp, true))
                                    {
                                        negated = new Bitmap(im);
                                    }

                                    Negate(negated);

                                    var add = ImageTools.Number2String(i);
                                    string f = Path.GetFileNameWithoutExtension(path);
                                    var newpath = path.Replace(f, f + add);

                                    newpath = System.IO.Path.ChangeExtension(newpath, "png");

                                    negated.Save(newpath, System.Drawing.Imaging.ImageFormat.Png);

                                }
                                catch (Exception Ex)
                                {
                                    errorMessage($"Could not invert slide {i}");
                                    System.Diagnostics.Trace.TraceError(Ex.Message);

                                    try
                                    {
                                        System.IO.File.Delete(temp);
                                    }
                                    catch (Exception e)
                                    {
                                        errorMessage(e.Message);
                                    }                                 
                                    continue;
                                }
                                finally
                                {
                                    negated?.Dispose();
                                 
                                }                                
                            }                            
                        }
                        finally
                        {
                            if(pptPresentation != null)
                            {
                                pptPresentation.Close();
                                Marshal.ReleaseComObject(pptPresentation);
                            }

                            bool allowQuit = true;
                            if (pptApplication.Presentations != null)
                            {
                                allowQuit = pptApplication.Presentations.Count == 0;
                                Marshal.ReleaseComObject(pptApplication.Presentations);
                            }

                            if (allowQuit)
                                pptApplication.Quit();

                            Marshal.ReleaseComObject(pptApplication);
                        }
                    }

                    BackupFile(backup, path, errorMessage);
                }
                else
                {
                   
                    Bitmap negated = null;
                    try
                    {
                        errorMessage($"Inverting {path}");

                        using (var im = Image.FromFile(path,true))
                        {
                            negated = new Bitmap(im);
                        }

                        Negate(negated);

                        var newPath = System.IO.Path.ChangeExtension(path, "png");

                        BackupFile(backup, path, errorMessage);

                        negated.Save(newPath, System.Drawing.Imaging.ImageFormat.Png);

                    }
                    catch (Exception e)
                    {
                        errorMessage(e.Message);
                    }
                    finally
                    {
                        negated?.Dispose();
                    }                    
                }              
            }            
        }

        private static void BackupFile(string backup, string file, Action<string> infoMsg)
        {
            var newpath = Path.Combine(backup, Path.GetFileName(file));
            try
            {               
                int i = 1;
                while (File.Exists(newpath))
                {
                    var add = ImageTools.Number2String(i);

                    string f = Path.GetFileNameWithoutExtension(file);
                    newpath = file.Replace(f, f + add);

                    //newpath = Path.Combine(backup, Path.GetFileName(file));
                    i++;
                }

                System.IO.File.Move(file, newpath);
            }
            catch (Exception e)
            {
                infoMsg("Error - BackupFile - " + e.Message);
            }

            infoMsg("File :" + file +" moved to: " + newpath);
        }


        public static String Number2String(int number, bool isCaps = false)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));

            return c.ToString();
        }

        private static void Negate(Bitmap image)
        {           

            const int RED_PIXEL = 2;
            const int GREEN_PIXEL = 1;
            const int BLUE_PIXEL = 0;


            BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);

            try
            {
                int stride = bmData.Stride;
                int bytesPerPixel = (image.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4);

                unsafe
                {
                    byte* pixel = (byte*)(void*)bmData.Scan0;
                    int yMax = image.Height;
                    int xMax = image.Width;

                    for (int y = 0; y < yMax; y++)
                    {
                        int yPos = y * stride;
                        for (int x =0; x < xMax; x++)
                        {
                            int pos = yPos + (x * bytesPerPixel);

                            pixel[pos + RED_PIXEL] = (byte)(255 - pixel[pos + RED_PIXEL]);
                            pixel[pos + GREEN_PIXEL] = (byte)(255 - pixel[pos + GREEN_PIXEL]);
                            pixel[pos + BLUE_PIXEL] = (byte)(255 - pixel[pos + BLUE_PIXEL]);
                        }

                    }
                }
            }
            finally
            {
                image.UnlockBits(bmData);
            }
        }      
    }
}
