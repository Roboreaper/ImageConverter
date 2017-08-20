using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class LogoSelecter : UserControl
    {
        public LogoSelecter()
        { 
            InitializeComponent();

            this.comboBoxLocation.Items.Clear();

            this.comboBoxLocation.Items.Add(new LogoLocation(eLogoLocation.TopLeft));
            this.comboBoxLocation.Items.Add(new LogoLocation(eLogoLocation.TopRight));
            this.comboBoxLocation.Items.Add(new LogoLocation(eLogoLocation.BottomLeft));
            this.comboBoxLocation.Items.Add(new LogoLocation(eLogoLocation.BottomRight));

            this.comboBoxLocation.SelectedIndex = 0;

        }

        public void SetLogoPath(string path)
        {
            this.textBoxLogo.Text = path;
        }

        public string GetLogoPath()
        {
            return this.textBoxLogo.Text;
        }

        public eLogoLocation LogoLocation()
        {
            var inx = this.comboBoxLocation.SelectedIndex;
            var item = this.comboBoxLocation.SelectedItem;

            return (item as LogoLocation)?.Location ?? eLogoLocation.TopLeft;
        }
    }

    public enum eLogoLocation
    {
        TopLeft,
        BottomLeft,
        TopRight,
        BottomRight,
    }

    public class LogoLocation
    {
        public eLogoLocation Location { get; set; }

        public LogoLocation(eLogoLocation loc)
        {
            this.Location = loc;
        }

        public override string ToString()
        {
            switch (Location)
            {
                case eLogoLocation.TopLeft:
                    return "Links Boven";
                case eLogoLocation.BottomLeft:
                    return "Links Onder";
                case eLogoLocation.TopRight:
                    return "Rechts Boven";
                case eLogoLocation.BottomRight:
                    return "Rechts Onder";
                default:
                    return "Error";
            }
        }
    }
}
