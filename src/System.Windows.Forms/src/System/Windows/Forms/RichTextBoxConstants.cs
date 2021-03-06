﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace System.Windows.Forms
{
    internal static class RichTextBoxConstants
    {
        // flags for enum that we don't want public
        //
        internal const int RTB_HORIZ = 0x0001;
        internal const int RTB_VERT = 0x0002;
        internal const int RTB_FORCE = 0x0010;

        /* RichTextBox messages */

        /* New edit control styles */
        internal const int ES_SAVESEL = 0x00008000;
        internal const int ES_SUNKEN = 0x00004000;
        internal const int ES_DISABLENOSCROLL = 0x00002000;
        /* same as WS_MAXIMIZE, but that doesn't make sense so we re-use the value */
        internal const int ES_SELECTIONBAR = 0x01000000;
        /* same as ES_UPPERCASE, but re-used to completely disable OLE drag'n'drop */
        internal const int ES_NOOLEDRAGDROP = 0x00000008;

        /* New edit control extended style */
        internal const int ES_EX_NOCALLOLEINIT = 0x01000000;

        /* These flags are used in FE Windows */
        internal const int ES_VERTICAL = 0x00400000; // NOT IN RE3.0/2.0
        internal const int ES_NOIME = 0x00080000;
        internal const int ES_SELFIME = 0x00040000;

        /* TextBox control options */
        internal const int ECO_AUTOWORDSELECTION = 0x00000001;
        internal const int ECO_AUTOVSCROLL = 0x00000040;
        internal const int ECO_AUTOHSCROLL = 0x00000080;
        internal const int ECO_NOHIDESEL = 0x00000100;
        internal const int ECO_READONLY = 0x00000800;
        internal const int ECO_WANTRETURN = 0x00001000;
        internal const int ECO_SAVESEL = 0x00008000;
        internal const int ECO_SELECTIONBAR = 0x01000000; // guessing this is selection margin
        internal const int ECO_VERTICAL = 0x00400000;   /* FE specific */

        /* ECO operations */
        internal const int ECOOP_SET = 0x0001;
        internal const int ECOOP_OR = 0x0002;
        internal const int ECOOP_AND = 0x0003;
        internal const int ECOOP_XOR = 0x0004;

        /* UNICODE embedding character */
        // disable csharp compiler warning #0414: field assigned unused value
#pragma warning disable 0414
        internal static readonly char WCH_EMBEDDING = (char)0xFFFC;
#pragma warning restore 0414
    }
}
