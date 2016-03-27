﻿namespace TipCalc.UITest.Xamarin.Common
{
    /// <summary>
    /// Based on: https://github.com/RobGibbens/BddWithXamarinUITest/blob/master/Simulator.cs
    /// https://forums.xamarin.com/discussion/comment/89870/#Comment_89870
    /// </summary>
    public class Simulator
    {
        public Simulator(string line)
        {
            ParseLine(line);
        }

        public string Line { get; private set; }

        public string GUID { get; private set; }

        public string Name { get; private set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(GUID) && !(string.IsNullOrWhiteSpace(Name));
        }

        public override string ToString()
        {
            return Line;
        }

        void ParseLine(string line)
        {

            GUID = string.Empty;
            Name = string.Empty;
            Line = string.Empty;

            if (string.IsNullOrWhiteSpace(line))
            {
                return;
            }
            Line = line.Trim();
            var idx1 = line.IndexOf(" [");
            if (idx1 < 1)
            {
                return;
            }

            Name = Line.Substring(0, idx1).Trim();
            GUID = Line.Substring(idx1 + 2, 36).Trim();
        }
    }
}
