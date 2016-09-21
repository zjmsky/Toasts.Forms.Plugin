﻿namespace Plugin.Toasts
{
    using System;

    [Flags]
    public enum NotificationResult
    {
        Timeout = 1, // Hides by itself
        Clicked = 2, // User clicked on notification
        Dismissed = 4, // User dismissed notification
        ApplicationHidden = 8 // Application went to background
    }
}