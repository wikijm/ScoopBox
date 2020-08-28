﻿using ScoopBox.Enums;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ScoopBox.Entities
{
    [XmlRoot(ElementName = nameof(Configuration))]
    public class Configuration
    {
        public Configuration()
        {
        }

        public Configuration(
            SandboxConfigurationOptions options,
            List<string> commands,
            MappedFolders mappedFolders)
        {
            LogonCommand = new LogonCommand();

            VGpu = Enum.GetName(typeof(VGpuOptions), options.VGpu);
            LogonCommand.Command = commands;
            this.MappedFolders = mappedFolders;
        }

        [XmlElement(ElementName = nameof(VGpu))]
        public string VGpu { get; set; }

        [XmlElement(ElementName = nameof(Networking))]
        public string Networking { get; set; }

        [XmlElement(ElementName = nameof(MappedFolders))]
        public MappedFolders MappedFolders { get; set; }

        [XmlElement(ElementName = nameof(LogonCommand))]
        public LogonCommand LogonCommand { get; set; }

        [XmlElement(ElementName = nameof(AudioInput))]
        public string AudioInput { get; set; }

        [XmlElement(ElementName = nameof(VideoInput))]
        public string VideoInput { get; set; }

        [XmlElement(ElementName = nameof(ProtectedClient))]
        public string ProtectedClient { get; set; }

        [XmlElement(ElementName = nameof(PrinterRedirection))]
        public string PrinterRedirection { get; set; }

        [XmlElement(ElementName = nameof(ClipboardRedirection))]
        public string ClipboardRedirection { get; set; }

        [XmlElement(ElementName = nameof(MemoryInMB))]
        public string MemoryInMB { get; set; }
    }
}
