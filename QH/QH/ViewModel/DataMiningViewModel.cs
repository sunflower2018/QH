using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using QH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using win.Logger;

namespace QH.ViewModel
{    
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class DataMiningViewModel : ViewModelBase
    {
        private qhDbContext context;
        /// <summary>
        /// Initializes a new instance of the ImportDataViewModel class.
        /// </summary>
        public DataMiningViewModel()
        {
            this.context = new qhDbContext();
        }
    }
}