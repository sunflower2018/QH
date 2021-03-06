﻿using System.Windows;
using QH.ViewModel;
using QH.Command;
using win.form.CtrlExt;
using System;
using win.Logger;
using System.Data.Entity;
using QH.Migrations;
using System.Data.Entity.Migrations;

namespace QH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void menuItem导入_Click(object sender, RoutedEventArgs e)
        {
            ImportDataWindow window = new ImportDataWindow();
            window.ShowDialog();
        }

        private void menuItem初始化数据库_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //创建上下文
                qhDbContext db = new qhDbContext();
                //创建数据库
                db.Database.CreateIfNotExists();
                this.ShowMessage("初始化数据成功");            
            }
            catch (Exception ex)
            {
                Logger.Info(string.Format("{0}:{1}",DateTime.Now, ex.Message));
            }
        }
        private void menuItem迁移数据库_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //自动迁移
                Database.SetInitializer<qhDbContext>(new MigrateDatabaseToLatestVersion<qhDbContext, Configuration>());
                var dbMigrator = new DbMigrator(new Configuration());
                dbMigrator.Update();
            }
            catch (Exception ex)
            {

            }
        }
    }
}