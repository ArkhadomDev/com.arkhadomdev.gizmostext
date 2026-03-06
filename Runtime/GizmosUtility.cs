using System.Collections.Generic;
using UnityEngine;

namespace Arkhadom.Utility
{    
    public static class GizmosUtility
    {
        private const string PackagePath = "Packages/com.arkhadomdev.gizmostext/Gizmos/";

        private static readonly Dictionary<char, string> CharacterMap = new Dictionary<char, string>();

        static GizmosUtility()
        {
            var rawMap = new Dictionary<char, string>
            {
                { 'A', "Letter_A" }, { 'B', "Letter_B" }, { 'C', "Letter_C" },
                { 'D', "Letter_D" }, { 'E', "Letter_E" }, { 'F', "Letter_F" },
                { 'G', "Letter_G" }, { 'H', "Letter_H" }, { 'I', "Letter_I" },
                { 'J', "Letter_J" }, { 'K', "Letter_K" }, { 'L', "Letter_L" },
                { 'M', "Letter_M" }, { 'N', "Letter_N" }, { 'O', "Letter_O" },
                { 'P', "Letter_P" }, { 'Q', "Letter_Q" }, { 'R', "Letter_R" },
                { 'S', "Letter_S" }, { 'T', "Letter_T" }, { 'U', "Letter_U" },
                { 'V', "Letter_V" }, { 'W', "Letter_W" }, { 'X', "Letter_X" },
                { 'Y', "Letter_Y" }, { 'Z', "Letter_Z" }, 
                { 'a', "Letter_lower_a" }, { 'b', "Letter_lower_b" }, { 'c', "Letter_lower_c" },
                { 'd', "Letter_lower_d" }, { 'e', "Letter_lower_e" }, { 'f', "Letter_lower_f" },
                { 'g', "Letter_lower_g" }, { 'h', "Letter_lower_h" }, { 'i', "Letter_lower_i" },
                { 'j', "Letter_lower_j" }, { 'k', "Letter_lower_k" }, { 'l', "Letter_lower_l" },
                { 'm', "Letter_lower_m" }, { 'n', "Letter_lower_n" }, { 'o', "Letter_lower_o" },
                { 'p', "Letter_lower_p" }, { 'q', "Letter_lower_q" }, { 'r', "Letter_lower_r" },
                { 's', "Letter_lower_s" }, { 't', "Letter_lower_t" }, { 'u', "Letter_lower_u" },
                { 'v', "Letter_lower_v" }, { 'w', "Letter_lower_w" }, { 'x', "Letter_lower_x" },
                { 'y', "Letter_lower_y" }, { 'z', "Letter_lower_z" },
                { '1', "Number_1" }, { '2', "Number_2" }, { '3', "Number_3" },
                { '4', "Number_4" }, { '5', "Number_5" }, { '6', "Number_6" },
                { '7', "Number_7" }, { '8', "Number_8" }, { '9', "Number_9" },
                { '0', "Number_0" }, { ',', "Comma" }, { '.', "Period" },
                { '/', "Slash" }, { '\\', "Backslash" }, { ':', "Colon" },
                { '-', "Hyphen" }, { '_', "Underscore" }, { ';', "Semicolon" },
                { '!', "Exclamation" }, { '?', "Question" }, { '|', "Pipe" },
                { '(', "Parentheses_Left" }, { ')', "Parentheses_Right" }
            };

            foreach (var kvp in rawMap)
            {
                CharacterMap.Add(kvp.Key, $"{PackagePath}{kvp.Value}.png");
            }
        }

        public static void DrawText(string text, Vector3 position, float spacing = 0.25f)
        {
            if (string.IsNullOrEmpty(text) || Camera.current == null) return;

            float totalWidth = (text.Length - 1) * spacing;
            Vector3 currentPos = position -  Camera.current.transform.right * (totalWidth / 2f);
            Vector3 movement = Camera.current.transform.right * spacing;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    currentPos += movement;
                    continue;
                }

                if (CharacterMap.TryGetValue(c, out var fullPath))
                {
                    Gizmos.DrawIcon(currentPos, fullPath, true);
                    currentPos += movement;
                }
            }
        }
    }
}