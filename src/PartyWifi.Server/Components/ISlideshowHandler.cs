﻿using PartyWifi.Server.Models;

namespace PartyWifi.Server.Components
{
    public interface ISlideshowHandler
    {
        int RotationMs { get; set; }

        void Initialize();

        ImageInfo Next();
    }
}