﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gavaghan.TrafficBuddy
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      mTopicPanel.CloseTopic();
    }
  }
}
