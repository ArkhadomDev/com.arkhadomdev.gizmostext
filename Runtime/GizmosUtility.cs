using UnityEngine;
using System.Collections.Generic;

public static class GizmosUtility
{
    private static readonly Dictionary<char, string> CharacterMap = new()
    {
        { 'A', "Letter_A" },
        { 'B', "Letter_B" },
        { 'C', "Letter_C" },
        { 'D', "Letter_D" },
        { 'E', "Letter_E" },
        { 'F', "Letter_F" },
        { 'G', "Letter_G" },
        { 'H', "Letter_H" },
        { 'I', "Letter_I" },
        { 'J', "Letter_J" },
        { 'K', "Letter_K" },
        { 'L', "Letter_L" },
        { 'M', "Letter_M" },
        { 'N', "Letter_N" },
        { 'O', "Letter_O" },
        { 'P', "Letter_P" },
        { 'Q', "Letter_Q" },
        { 'R', "Letter_R" },
        { 'S', "Letter_S" },
        { 'T', "Letter_T" },
        { 'U', "Letter_U" },
        { 'V', "Letter_V" },
        { 'W', "Letter_W" },
        { 'X', "Letter_X" },
        { 'Y', "Letter_Y" },
        { 'Z', "Letter_Z" },
        { '1', "Number_1" },
        { '2', "Number_2" },
        { '3', "Number_3" },
        { '4', "Number_4" },
        { '5', "Number_5" },
        { '6', "Number_6" },
        { '7', "Number_7" },
        { '8', "Number_8" },
        { '9', "Number_9" },
        { '0', "Number_0" },
        { ',', "Comma" },
        { '.', "Period" },
        { '/', "Slash" },
        { ':', "Colon" },
        { ' ', "Space" }
    };

    public static void DrawText(string text, Vector3 position, float spacing = 0.25f)
    {
        float totalWidth = (text.Length - 1) * spacing;
        Vector3 currentPos = position - (Camera.current.transform.right * (totalWidth / 2f));

        string upperText = text.ToUpper();

        foreach (var character in upperText)
        {
            if (CharacterMap.TryGetValue(character, out string iconName))
            {
                if (character != ' ')
                {
                    Gizmos.DrawIcon(currentPos, iconName, true);
                }
                
                currentPos.x += spacing;
            }
        }
    }
}
