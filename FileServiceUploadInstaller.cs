﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace SendingResults
{
    [RunInstaller(true)]
    public partial class FileServiceUploadInstaller : System.Configuration.Install.Installer
    {
        public FileServiceUploadInstaller()
        {
            InitializeComponent();
        }
    }
}
