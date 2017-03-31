// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Speech.V1
{
    /// <summary>
    /// A helper class forming a hierarchy of supported language codes, via nested classes.
    /// All language codes are eventually represented as string constants. This is simply
    /// a code-convenient form of the table at https://cloud.google.com/speech/docs/languages.
    /// It is regenerated regularly, but not guaranteed to be complete at any moment in time;
    /// if the language you wish to use is present in the table but not covered here, please use
    /// the listed language code as a hard-coded string until this class catches up.
    /// </summary>
    public static class LanguageCodes
    {
        // To populate this class, run the LanguageCodeGenerator project and check how many entries
        // are reported. If it's different to the number reported below, replace everything below
        // (to just before the closing brace of this class) with the generated text in
        // language-codes.tmp.txt.

        // Generated 2017-03-31; 89 entries.

        /// <summary>Language codes for Afrikaans.</summary>
        public static class Afrikaans
        {
            /// <summary>Language code for Afrikaans (South Africa)</summary>
            public const string SouthAfrica = "af-ZA";

        }

        /// <summary>Language codes for Arabic.</summary>
        public static class Arabic
        {
            /// <summary>Language code for Arabic (Algeria)</summary>
            public const string Algeria = "ar-DZ";

            /// <summary>Language code for Arabic (Bahrain)</summary>
            public const string Bahrain = "ar-BH";

            /// <summary>Language code for Arabic (Egypt)</summary>
            public const string Egypt = "ar-EG";

            /// <summary>Language code for Arabic (Iraq)</summary>
            public const string Iraq = "ar-IQ";

            /// <summary>Language code for Arabic (Israel)</summary>
            public const string Israel = "ar-IL";

            /// <summary>Language code for Arabic (Jordan)</summary>
            public const string Jordan = "ar-JO";

            /// <summary>Language code for Arabic (Kuwait)</summary>
            public const string Kuwait = "ar-KW";

            /// <summary>Language code for Arabic (Lebanon)</summary>
            public const string Lebanon = "ar-LB";

            /// <summary>Language code for Arabic (Morocco)</summary>
            public const string Morocco = "ar-MA";

            /// <summary>Language code for Arabic (Oman)</summary>
            public const string Oman = "ar-OM";

            /// <summary>Language code for Arabic (Qatar)</summary>
            public const string Qatar = "ar-QA";

            /// <summary>Language code for Arabic (Saudi Arabia)</summary>
            public const string SaudiArabia = "ar-SA";

            /// <summary>Language code for Arabic (State of Palestine)</summary>
            public const string StateofPalestine = "ar-PS";

            /// <summary>Language code for Arabic (Tunisia)</summary>
            public const string Tunisia = "ar-TN";

            /// <summary>Language code for Arabic (United Arab Emirates)</summary>
            public const string UnitedArabEmirates = "ar-AE";

        }

        /// <summary>Language codes for Basque.</summary>
        public static class Basque
        {
            /// <summary>Language code for Basque (Spain)</summary>
            public const string Spain = "eu-ES";

        }

        /// <summary>Language codes for Bulgarian.</summary>
        public static class Bulgarian
        {
            /// <summary>Language code for Bulgarian (Bulgaria)</summary>
            public const string Bulgaria = "bg-BG";

        }

        /// <summary>Language codes for Catalan.</summary>
        public static class Catalan
        {
            /// <summary>Language code for Catalan (Spain)</summary>
            public const string Spain = "ca-ES";

        }

        /// <summary>Language codes for Chinese, Cantonese.</summary>
        public static class ChineseCantonese
        {
            /// <summary>Language code for Chinese, Cantonese (Traditional, Hong Kong)</summary>
            public const string TraditionalHongKong = "yue-Hant-HK";

        }

        /// <summary>Language codes for Chinese, Mandarin.</summary>
        public static class ChineseMandarin
        {
            /// <summary>Language code for Chinese, Mandarin (Simplified, China)</summary>
            public const string SimplifiedChina = "cmn-Hans-CN";

            /// <summary>Language code for Chinese, Mandarin (Simplified, Hong Kong)</summary>
            public const string SimplifiedHongKong = "cmn-Hans-HK";

            /// <summary>Language code for Chinese, Mandarin (Traditional, Taiwan)</summary>
            public const string TraditionalTaiwan = "cmn-Hant-TW";

        }

        /// <summary>Language codes for Croatian.</summary>
        public static class Croatian
        {
            /// <summary>Language code for Croatian (Croatia)</summary>
            public const string Croatia = "hr-HR";

        }

        /// <summary>Language codes for Czech.</summary>
        public static class Czech
        {
            /// <summary>Language code for Czech (Czech Republic)</summary>
            public const string CzechRepublic = "cs-CZ";

        }

        /// <summary>Language codes for Danish.</summary>
        public static class Danish
        {
            /// <summary>Language code for Danish (Denmark)</summary>
            public const string Denmark = "da-DK";

        }

        /// <summary>Language codes for Dutch.</summary>
        public static class Dutch
        {
            /// <summary>Language code for Dutch (Netherlands)</summary>
            public const string Netherlands = "nl-NL";

        }

        /// <summary>Language codes for English.</summary>
        public static class English
        {
            /// <summary>Language code for English (Australia)</summary>
            public const string Australia = "en-AU";

            /// <summary>Language code for English (Canada)</summary>
            public const string Canada = "en-CA";

            /// <summary>Language code for English (India)</summary>
            public const string India = "en-IN";

            /// <summary>Language code for English (Ireland)</summary>
            public const string Ireland = "en-IE";

            /// <summary>Language code for English (New Zealand)</summary>
            public const string NewZealand = "en-NZ";

            /// <summary>Language code for English (Philippines)</summary>
            public const string Philippines = "en-PH";

            /// <summary>Language code for English (South Africa)</summary>
            public const string SouthAfrica = "en-ZA";

            /// <summary>Language code for English (United Kingdom)</summary>
            public const string UnitedKingdom = "en-GB";

            /// <summary>Language code for English (United States)</summary>
            public const string UnitedStates = "en-US";

        }

        /// <summary>Language codes for Filipino.</summary>
        public static class Filipino
        {
            /// <summary>Language code for Filipino (Philippines)</summary>
            public const string Philippines = "fil-PH";

        }

        /// <summary>Language codes for Finnish.</summary>
        public static class Finnish
        {
            /// <summary>Language code for Finnish (Finland)</summary>
            public const string Finland = "fi-FI";

        }

        /// <summary>Language codes for French.</summary>
        public static class French
        {
            /// <summary>Language code for French (Canada)</summary>
            public const string Canada = "fr-CA";

            /// <summary>Language code for French (France)</summary>
            public const string France = "fr-FR";

        }

        /// <summary>Language codes for Galician.</summary>
        public static class Galician
        {
            /// <summary>Language code for Galician (Spain)</summary>
            public const string Spain = "gl-ES";

        }

        /// <summary>Language codes for German.</summary>
        public static class German
        {
            /// <summary>Language code for German (Germany)</summary>
            public const string Germany = "de-DE";

        }

        /// <summary>Language codes for Greek.</summary>
        public static class Greek
        {
            /// <summary>Language code for Greek (Greece)</summary>
            public const string Greece = "el-GR";

        }

        /// <summary>Language codes for Hebrew.</summary>
        public static class Hebrew
        {
            /// <summary>Language code for Hebrew (Israel)</summary>
            public const string Israel = "he-IL";

        }

        /// <summary>Language codes for Hindi.</summary>
        public static class Hindi
        {
            /// <summary>Language code for Hindi (India)</summary>
            public const string India = "hi-IN";

        }

        /// <summary>Language codes for Hungarian.</summary>
        public static class Hungarian
        {
            /// <summary>Language code for Hungarian (Hungary)</summary>
            public const string Hungary = "hu-HU";

        }

        /// <summary>Language codes for Icelandic.</summary>
        public static class Icelandic
        {
            /// <summary>Language code for Icelandic (Iceland)</summary>
            public const string Iceland = "is-IS";

        }

        /// <summary>Language codes for Indonesian.</summary>
        public static class Indonesian
        {
            /// <summary>Language code for Indonesian (Indonesia)</summary>
            public const string Indonesia = "id-ID";

        }

        /// <summary>Language codes for Italian.</summary>
        public static class Italian
        {
            /// <summary>Language code for Italian (Italy)</summary>
            public const string Italy = "it-IT";

        }

        /// <summary>Language codes for Japanese.</summary>
        public static class Japanese
        {
            /// <summary>Language code for Japanese (Japan)</summary>
            public const string Japan = "ja-JP";

        }

        /// <summary>Language codes for Korean.</summary>
        public static class Korean
        {
            /// <summary>Language code for Korean (South Korea)</summary>
            public const string SouthKorea = "ko-KR";

        }

        /// <summary>Language codes for Lithuanian.</summary>
        public static class Lithuanian
        {
            /// <summary>Language code for Lithuanian (Lithuania)</summary>
            public const string Lithuania = "lt-LT";

        }

        /// <summary>Language codes for Malay.</summary>
        public static class Malay
        {
            /// <summary>Language code for Malay (Malaysia)</summary>
            public const string Malaysia = "ms-MY";

        }

        /// <summary>Language codes for Norwegian Bokmål.</summary>
        public static class NorwegianBokmal
        {
            /// <summary>Language code for Norwegian Bokmål (Norway)</summary>
            public const string Norway = "nb-NO";

        }

        /// <summary>Language codes for Persian.</summary>
        public static class Persian
        {
            /// <summary>Language code for Persian (Iran)</summary>
            public const string Iran = "fa-IR";

        }

        /// <summary>Language codes for Polish.</summary>
        public static class Polish
        {
            /// <summary>Language code for Polish (Poland)</summary>
            public const string Poland = "pl-PL";

        }

        /// <summary>Language codes for Portuguese.</summary>
        public static class Portuguese
        {
            /// <summary>Language code for Portuguese (Brazil)</summary>
            public const string Brazil = "pt-BR";

            /// <summary>Language code for Portuguese (Portugal)</summary>
            public const string Portugal = "pt-PT";

        }

        /// <summary>Language codes for Romanian.</summary>
        public static class Romanian
        {
            /// <summary>Language code for Romanian (Romania)</summary>
            public const string Romania = "ro-RO";

        }

        /// <summary>Language codes for Russian.</summary>
        public static class Russian
        {
            /// <summary>Language code for Russian (Russia)</summary>
            public const string Russia = "ru-RU";

        }

        /// <summary>Language codes for Serbian.</summary>
        public static class Serbian
        {
            /// <summary>Language code for Serbian (Serbia)</summary>
            public const string Serbia = "sr-RS";

        }

        /// <summary>Language codes for Slovak.</summary>
        public static class Slovak
        {
            /// <summary>Language code for Slovak (Slovakia)</summary>
            public const string Slovakia = "sk-SK";

        }

        /// <summary>Language codes for Slovenian.</summary>
        public static class Slovenian
        {
            /// <summary>Language code for Slovenian (Slovenia)</summary>
            public const string Slovenia = "sl-SI";

        }

        /// <summary>Language codes for Spanish.</summary>
        public static class Spanish
        {
            /// <summary>Language code for Spanish (Argentina)</summary>
            public const string Argentina = "es-AR";

            /// <summary>Language code for Spanish (Bolivia)</summary>
            public const string Bolivia = "es-BO";

            /// <summary>Language code for Spanish (Chile)</summary>
            public const string Chile = "es-CL";

            /// <summary>Language code for Spanish (Colombia)</summary>
            public const string Colombia = "es-CO";

            /// <summary>Language code for Spanish (Costa Rica)</summary>
            public const string CostaRica = "es-CR";

            /// <summary>Language code for Spanish (Dominican Republic)</summary>
            public const string DominicanRepublic = "es-DO";

            /// <summary>Language code for Spanish (Ecuador)</summary>
            public const string Ecuador = "es-EC";

            /// <summary>Language code for Spanish (El Salvador)</summary>
            public const string ElSalvador = "es-SV";

            /// <summary>Language code for Spanish (Guatemala)</summary>
            public const string Guatemala = "es-GT";

            /// <summary>Language code for Spanish (Honduras)</summary>
            public const string Honduras = "es-HN";

            /// <summary>Language code for Spanish (Mexico)</summary>
            public const string Mexico = "es-MX";

            /// <summary>Language code for Spanish (Nicaragua)</summary>
            public const string Nicaragua = "es-NI";

            /// <summary>Language code for Spanish (Panama)</summary>
            public const string Panama = "es-PA";

            /// <summary>Language code for Spanish (Paraguay)</summary>
            public const string Paraguay = "es-PY";

            /// <summary>Language code for Spanish (Peru)</summary>
            public const string Peru = "es-PE";

            /// <summary>Language code for Spanish (Puerto Rico)</summary>
            public const string PuertoRico = "es-PR";

            /// <summary>Language code for Spanish (Spain)</summary>
            public const string Spain = "es-ES";

            /// <summary>Language code for Spanish (United States)</summary>
            public const string UnitedStates = "es-US";

            /// <summary>Language code for Spanish (Uruguay)</summary>
            public const string Uruguay = "es-UY";

            /// <summary>Language code for Spanish (Venezuela)</summary>
            public const string Venezuela = "es-VE";

        }

        /// <summary>Language codes for Swedish.</summary>
        public static class Swedish
        {
            /// <summary>Language code for Swedish (Sweden)</summary>
            public const string Sweden = "sv-SE";

        }

        /// <summary>Language codes for Thai.</summary>
        public static class Thai
        {
            /// <summary>Language code for Thai (Thailand)</summary>
            public const string Thailand = "th-TH";

        }

        /// <summary>Language codes for Turkish.</summary>
        public static class Turkish
        {
            /// <summary>Language code for Turkish (Turkey)</summary>
            public const string Turkey = "tr-TR";

        }

        /// <summary>Language codes for Ukrainian.</summary>
        public static class Ukrainian
        {
            /// <summary>Language code for Ukrainian (Ukraine)</summary>
            public const string Ukraine = "uk-UA";

        }

        /// <summary>Language codes for Vietnamese.</summary>
        public static class Vietnamese
        {
            /// <summary>Language code for Vietnamese (Vietnam)</summary>
            public const string Vietnam = "vi-VN";

        }

        /// <summary>Language codes for Zulu.</summary>
        public static class Zulu
        {
            /// <summary>Language code for Zulu (South Africa)</summary>
            public const string SouthAfrica = "zu-ZA";

        }
    }
}
