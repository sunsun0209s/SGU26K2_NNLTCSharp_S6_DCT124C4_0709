using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Lab05Prj;

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "test-fix")
        {
            var f = new Forms.FrmXuLyChuoi();
            f.Show();
            
            var btnNN = f.Controls.Find("btnNgauNhien", true)[0] as Button;
            btnNN!.PerformClick();

            var lst = f.Controls.Find("lstHoTen", true)[0] as ListBox;
            lst!.ClearSelected();
            lst.SetSelected(7, true);

            int idx = 7;
            string text = lst.Items[idx]?.ToString() ?? "";
            
            // TEST FIX:
            lst.BeginUpdate();
            lst.Items.RemoveAt(idx);
            lst.Items.Insert(idx, text.ToUpper());
            lst.SetSelected(idx, true);
            lst.EndUpdate();
            lst.Refresh();

            Bitmap bmp = new Bitmap(f.Width, f.Height);
            f.DrawToBitmap(bmp, new Rectangle(0, 0, f.Width, f.Height));
            bmp.Save("test_fix_render.png", ImageFormat.Png);

            f.Close();
            return;
        }

        ApplicationConfiguration.Initialize();
        Application.Run(new Forms.FrmMain());
    }    
}
