using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFoodFacts4Net.ApiClient
{
    static class StringBuilderExtensions
    {
        public static bool IsEmpty(this StringBuilder stringBuilder)
        {
            return (stringBuilder.Length == 0);
        }

        /// <summary>
        /// Ajoute la chaîne <paramref name="str"/> au <paramref name="stringBuilder"/> si <paramref name="stringBuilder"/> non vide
        /// </summary>
        /// <param name="stringBuilder">StringBuilder</param>
        /// <param name="str">Chaîne à ajouter au <paramref name="stringBuilder"/></param>
        /// <returns>StringBuilder</returns>
        public static StringBuilder AppendIfNotEmpty(this StringBuilder stringBuilder, String str)
        {
            if (!stringBuilder.IsEmpty())
                stringBuilder.Append(str);

            return stringBuilder;
        }

        /// <summary>
        /// Ajoute un espace au <paramref name="stringBuilder"/> si <paramref name="stringBuilder"/> non vide
        /// </summary>
        /// <param name="stringBuilder">StringBuilder</param>
        /// <returns>StringBuilder</returns>
        public static StringBuilder AppendSpaceIfNotEmpty(this StringBuilder stringBuilder)
        {
            stringBuilder.AppendIfNotEmpty(" ");
            return stringBuilder;
        }
    }
}
