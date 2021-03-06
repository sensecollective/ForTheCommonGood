﻿using System;
using System.Windows.Forms;

namespace ForTheCommonGood
{
    public partial class frmRevisionBrowse: Form
    {
        public frmRevisionBrowse()
        {
            InitializeComponent();

            Text = Localization.GetString("SelectVersion_WindowTitle");
            lblBlurb.Text = Localization.GetString("SelectVersionBlurb_Label");
            colComment.Text = Localization.GetString("Comment_Column");
            colDateTime.Text = Localization.GetString("DateTime_Column");
            colDimensions.Text = Localization.GetString("Dimensions_Column");
            colPreview.Text = Localization.GetString("Preview_Column");
            colUser.Text = Localization.GetString("UserName_Column");
            button1.Text = Localization.GetString("OK_Button");
            button2.Text = Localization.GetString("Cancel_Button");
            btnSelectAll.Text = Localization.GetString("SelectAllVersions_Button");
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView.Items)
                i.Selected = true;
            listView.Focus();
        }
    }
}
