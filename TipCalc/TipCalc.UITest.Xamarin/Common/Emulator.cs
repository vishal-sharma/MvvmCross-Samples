﻿namespace TipCalc.UITest.Xamarin.Common
{
    public class Emulator
    {
        public Emulator(string line)
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
            var idx1 = line.IndexOf(" {");
            if (idx1 < 1)
            {
                return;
            }

            Name = Line.Substring(1, idx1 - 2).Trim();
            GUID = Line.Substring(idx1 + 2, 36).Trim();

        }
    }
}
