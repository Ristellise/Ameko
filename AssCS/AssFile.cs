﻿using System.Collections.Generic;

namespace Ameko.AssCS
{
    /// <summary>
    /// An ASS subtitle file and everything within
    /// </summary>
    /// <author>9volt</author>
    public class AssFile
    {
        public AssInfo ScriptInfo { get; private set; }
        public List<AssStyle> Styles { get; private set; }
        public List<AssEvent> Events { get; private set; }

        /// <summary>
        /// Create a new ASS file representation
        /// </summary>
        /// <param name="scriptInfo">Script information dictionary</param>
        /// <param name="styles">List of styles</param>
        /// <param name="events">List of events</param>
        public AssFile(AssInfo scriptInfo, List<AssStyle> styles, List<AssEvent> events)
        {
            ScriptInfo = scriptInfo;
            Styles = styles;
            Events = events;
        }
    }
}