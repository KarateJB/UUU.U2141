using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.UserInfo.Model
{
    public class UserInfo
    {
        private string path = $"{AppDomain.CurrentDomain.BaseDirectory}//UserInfo.ini";
        private string _name = string.Empty;

        private DateTime _modiftOn { get; set; } = DateTime.Now;

        public System.Drawing.Color BackColor { get; set; }
        public String Name {
            get => this._name;
            set { this._name = value; }
        }

        public void Save()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(this.Name);
                sw.WriteLine(this.BackColor);
                sw.WriteLine(DateTime.Now.ToString());
            }
        }

        public void Load()
        {
            if (!File.Exists(path))
            {
                this.Name = string.Empty;
                this.BackColor = System.Drawing.Color.Black;
                this._modiftOn = DateTime.Now;
            }
            else
            {
                using (var sr = new StreamReader(this.path))
                {
                    this.Name = sr.ReadLine();
                    this.BackColor = System.Drawing.Color.FromArgb(int.Parse(sr.ReadLine()));
                    this._modiftOn = DateTime.Parse(sr.ReadLine());
                }
            }
        }
    }
}
