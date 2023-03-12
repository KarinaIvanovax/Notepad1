﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad1
{
    public partial class FontSettings : Form
        {
            public int FontSize = 0;
            public System.Drawing.FontStyle fs = FontStyle.Regular;

            public FontSettings()
            {
                InitializeComponent();
                FontBox.SelectedItem = FontBox.Items[0];
                StyleBox.SelectedItem = StyleBox.Items[0];
            }

            private void OnFontChanged(object sender, EventArgs e)
            {
                ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), ExampleText.Font.Style);
                FontSize = int.Parse(FontBox.SelectedItem.ToString());
            }

            private void OnStyleChanged(object sender, EventArgs e)
            {
                switch (StyleBox.SelectedItem.ToString())
                {
                    case "обычный":
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Regular);
                        break;
                    case "курсив":
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Italic);
                        break;
                    case "полужирный":
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Bold);
                        break;
                    case "линия по середине":
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Strikeout);
                        break;
                    case "подчеркивание":
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Underline);
                        break;

                }
                fs = ExampleText.Font.Style;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
            }
        }
    }
