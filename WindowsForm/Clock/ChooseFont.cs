﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
    public partial class ChooseFont : Form
    {
        public Font ChosenFont { get; private set; }
        public ChooseFont()
        {
            InitializeComponent();
            LoadFonts();
        }
        void LoadFonts()
        {
            // 1. получаем список всех файлов в текущ. каталоге, и сохр. этот список в массив 'fonts':
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            // 2. поскольку в массиве хранятся полные пути к файлам, убираем пути и оставляем только названия:
            for (int i = 0; i < fonts.Length; i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            // 3. загружаем весь массив файлов в combobox
            comboBoxFonts.Items.AddRange(fonts);
            comboBoxFonts.SelectedIndex = 1;
        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            string fontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            MessageBox.Show(fontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontFile);
            Font font = new Font(pfc.Families[0], 36);
            labelExample.Font = font;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChosenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size);

        }
    }
}
