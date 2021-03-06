﻿using TipCalc.UITest.Windows.Common;

namespace TipCalc.UITest.Windows.Screens.TipCalcViewUIMapClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITest.Input;
    using MouseButtons = Microsoft.VisualStudio.TestTools.UITest.Input.MouseButtons;
    
    
    public partial class TipCalcViewUIMap : UIMapBase
    {
        public override string XamlRoot => nameof(this.UITipCalcUIUWPWindow);
    }
}
