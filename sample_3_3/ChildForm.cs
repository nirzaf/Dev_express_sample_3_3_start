using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace sample_3_3 {
  public partial class ChildForm : DevExpress.XtraEditors.XtraForm {
    public ChildForm() {
      InitializeComponent();

      var r = new Random((int) DateTime.Now.Ticks);      panel1.BackColor =        Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
    }
  }
}