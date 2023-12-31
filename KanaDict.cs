using System.Collections.Generic;

public static class KanaDict
{
    // Used for Hiragana Module
    public static readonly Dictionary<string, List<string>> HiraganaList = new Dictionary<string, List<string>>()
    {
        // 普通
        { "あ", new List<string> { "a" } }, { "い", new List<string> { "i" } }, { "う", new List<string> { "u" } }, { "え", new List<string> { "e" } }, { "お", new List<string> { "o" } },
        { "か", new List<string> { "ka" } }, { "き", new List<string> { "ki" } }, { "く", new List<string> { "ku" } }, { "け", new List<string> { "ke" } }, { "こ", new List<string> { "ko" } },
        { "さ", new List<string> { "sa" } }, { "し", new List<string> { "shi", "si" } }, { "す", new List<string> { "su" } }, { "せ", new List<string> { "se" } }, { "そ", new List<string> { "so" } },
        { "た", new List<string> { "ta" } }, { "ち", new List<string> { "chi", "ti" } }, { "つ", new List<string> { "tsu", "tu" } }, { "て", new List<string> { "te" } }, { "と", new List<string> { "to" } },
        { "な", new List<string> { "na" } }, { "に", new List<string> { "ni" } }, { "ぬ", new List<string> { "nu" } }, { "ね", new List<string> { "ne" } }, { "の", new List<string> { "no" } },
        { "は", new List<string> { "ha" } }, { "ひ", new List<string> { "hi" } }, { "ふ", new List<string> { "fu", "hu" } }, { "へ", new List<string> { "he" } }, { "ほ", new List<string> { "ho" } },
        { "ま", new List<string> { "ma" } }, { "み", new List<string> { "mi" } }, { "む", new List<string> { "mu" } }, { "め", new List<string> { "me" } }, { "も", new List<string> { "mo" } },
        { "や", new List<string> { "ya" } }, { "ゆ", new List<string> { "yu" } }, { "よ", new List<string> { "yo" } },
        { "ら", new List<string> { "ra" } }, { "り", new List<string> { "ri" } }, { "る", new List<string> { "ru" } }, { "れ", new List<string> { "re" } }, { "ろ", new List<string> { "ro" } },
        { "わ", new List<string> { "wa" } }, { "を", new List<string> { "wo", "o" } }, { "ん", new List<string> { "n", "nn" } },

        // 点々
        { "が", new List<string> { "ga" } }, { "ぎ", new List<string> { "gi" } }, { "ぐ", new List<string> { "gu" } }, { "げ", new List<string> { "ge" } }, { "ご", new List<string> { "go" } },
        { "ざ", new List<string> { "za" } }, { "じ", new List<string> { "ji", "zi" } }, { "ず", new List<string> { "zu" } }, { "ぜ", new List<string> { "ze" } }, { "ぞ", new List<string> { "zo" } },
        { "だ", new List<string> { "da" } }, { "ぢ", new List<string> { "ji", "di" } }, { "づ", new List<string> { "zu", "du" } }, { "で", new List<string> { "de" } }, { "ど", new List<string> { "do" } },
        { "ば", new List<string> { "ba" } }, { "び", new List<string> { "bi" } }, { "ぶ", new List<string> { "bu" } }, { "べ", new List<string> { "be" } }, { "ぼ", new List<string> { "bo" } },
            

        // 丸
        { "ぱ", new List<string> { "pa" } }, { "ぴ", new List<string> { "pi" } }, { "ぷ", new List<string> { "pu" } }, { "ぺ", new List<string> { "pe" } }, { "ぽ", new List<string> { "po" } },


        // 拗音
        { "きゃ", new List<string> { "kya" } }, { "きゅ", new List<string> { "kyu" } }, { "きょ", new List<string> { "kyo" } },
        { "にゃ", new List<string> { "nya" } }, { "にゅ", new List<string> { "nyu" } }, { "にょ", new List<string> { "nyo" } },
        { "しゃ", new List<string> { "sha", "sya" } }, { "しゅ", new List<string> { "shu", "syu" } }, { "しょ", new List<string> { "sho", "syo" } },
        { "ちゃ", new List<string> { "cha", "cya", "tya" } }, { "ちゅ", new List<string> { "chu", "cyu", "tyu" } }, { "ちょ", new List<string> { "cho", "cyo", "tyo" } },
        { "ひゃ", new List<string> { "hya" } }, { "ひゅ", new List<string> { "hyu" } }, { "ひょ", new List<string> { "hyo" } },
        { "みゃ", new List<string> { "mya" } }, { "みゅ", new List<string> { "myu" } }, { "みょ", new List<string> { "myo" } },
        { "りゃ", new List<string> { "rya" } }, { "りゅ", new List<string> { "ryu" } }, { "りょ", new List<string> { "ryo" } },
        { "ぎゃ", new List<string> { "gya" } }, { "ぎゅ", new List<string> { "gyu" } }, { "ぎょ", new List<string> { "gyo" } },
        { "じゃ", new List<string> { "jya", "ja", "zya" } }, { "じゅ", new List<string> { "jyu", "ju", "zyu" } }, { "じょ", new List<string> { "jyo", "jo", "zyo" } },
        { "ぢゃ", new List<string> { "jya", "dyu", "ja" } }, { "ぢゅ", new List<string> { "jyu", "dyu", "ju" } }, { "ぢょ", new List<string> { "jyo", "dyo", "jo" } },
        { "びゃ", new List<string> { "bya" } }, { "びゅ", new List<string> { "byu" } }, { "びょ", new List<string> { "byo" } },
        { "ぴゃ", new List<string> { "pya" } }, { "ぴゅ", new List<string> { "pyu" } }, { "ぴょ", new List<string> { "pyo" } },
    };

    // Used for Hiragana Module
    public static readonly Dictionary<string, List<string>> HiraganaExtrasList = new Dictionary<string, List<string>>()
    {
        { "ゐ", new List<string> { "wyi", "wi" } },
        { "ゑ", new List<string> { "wye", "we" } },
        { "いぇ", new List<string> { "ye" } },
        { "うぁ", new List<string> { "wha" } },
        { "うぃ", new List<string> { "whi", "wi" } },
        { "うぇ", new List<string> { "whe", "we" } },
        { "うぉ", new List<string> { "who" } },
        { "くぁ", new List<string> { "qa" } },
        { "くぃ", new List<string> { "qi" } },
        { "くぇ", new List<string> { "qe" } },
        { "くぉ", new List<string> { "qo" } },
        { "すぁ", new List<string> { "swa" } },
        { "すぃ", new List<string> { "swi" } },
        { "すぅ", new List<string> { "swu" } },
        { "すぇ", new List<string> { "swe" } },
        { "すぉ", new List<string> { "swo" } },
        { "つぁ", new List<string> { "tsa" } },
        { "つぃ", new List<string> { "tsi" } },
        { "つぇ", new List<string> { "tse" } },
        { "つぉ", new List<string> { "tso" } },
        { "てゃ", new List<string> { "tha" } },
        { "てぃ", new List<string> { "thi" } },
        { "てゅ", new List<string> { "thu" } },
        { "てぇ", new List<string> { "the" } },
        { "てょ", new List<string> { "tho" } },
        { "とぁ", new List<string> { "twa" } },
        { "とぃ", new List<string> { "twi" } },
        { "とぅ", new List<string> { "twu" } },
        { "とぇ", new List<string> { "twe" } },
        { "とぉ", new List<string> { "two" } },
        { "ふぁ", new List<string> { "fa" } },
        { "ふぃ", new List<string> { "fi" } },
        { "ふぇ", new List<string> { "fe" } },
        { "ふぉ", new List<string> { "fo" } },
        { "ふゃ", new List<string> { "fya" } },
        { "ふゅ", new List<string> { "fyu" } },
        { "ふょ", new List<string> { "fyo" } },
        { "ぐぁ", new List<string> { "gwa" } },
        { "ぐぃ", new List<string> { "gwi" } },
        { "ぐぅ", new List<string> { "gwu" } },
        { "ぐぇ", new List<string> { "gwe" } },
        { "ぐぉ", new List<string> { "gwo" } },
        { "でゃ", new List<string> { "dha" } },
        { "でぃ", new List<string> { "dhi" } },
        { "でゅ", new List<string> { "dhu" } },
        { "でぇ", new List<string> { "dhe" } },
        { "でょ", new List<string> { "dho" } },
        { "どぁ", new List<string> { "dwa" } },
        { "どぃ", new List<string> { "dwi" } },
        { "どぅ", new List<string> { "dwu" } },
        { "どぇ", new List<string> { "dwe" } },
        { "どぉ", new List<string> { "dwo" } },
        { "ゔぁ", new List<string> { "va" } },
        { "ゔぃ", new List<string> { "vi" } },
        { "ゔ", new List<string> { "vu" } },
        { "ゔぇ", new List<string> { "ve" } },
        { "ゔぉ", new List<string> { "vo" } },
        { "ゔゃ", new List<string> { "vya" } },
        { "ゔゅ", new List<string> { "vyu" } },
        { "ゔょ", new List<string> { "vyo" } },
    };

    // Used for Katakana Module
    public static readonly Dictionary<string, List<string>> KatakanaList = new Dictionary<string, List<string>>()
    {
        // 普通
        { "ア", new List<string> { "a" } }, { "イ", new List<string> { "i" } }, { "ウ", new List<string> { "u" } }, { "エ", new List<string> { "e" } }, { "オ", new List<string> { "o" } },
        { "カ", new List<string> { "ka" } }, { "キ", new List<string> { "ki" } }, { "ク", new List<string> { "ku" } }, { "ケ", new List<string> { "ke" } }, { "コ", new List<string> { "ko" } },
        { "サ", new List<string> { "sa" } }, { "シ", new List<string> { "shi", "si" } }, { "ス", new List<string> { "su" } }, { "セ", new List<string> { "se" } }, { "ソ", new List<string> { "so" } },
        { "タ", new List<string> { "ta" } }, { "チ", new List<string> { "chi", "ti" } }, { "ツ", new List<string> { "tsu", "tu" } }, { "テ", new List<string> { "te" } }, { "ト", new List<string> { "to" } },
        { "ナ", new List<string> { "na" } }, { "ニ", new List<string> { "ni" } }, { "ヌ", new List<string> { "nu" } }, { "ネ", new List<string> { "ne" } }, { "ノ", new List<string> { "no" } },
        { "ハ", new List<string> { "ha" } }, { "ヒ", new List<string> { "hi" } }, { "フ", new List<string> { "fu", "hu" } }, { "へ", new List<string> { "he" } }, { "ホ", new List<string> { "ho" } },
        { "マ", new List<string> { "ma" } }, { "ミ", new List<string> { "mi" } }, { "ム", new List<string> { "mu" } }, { "メ", new List<string> { "me" } }, { "モ", new List<string> { "mo" } },
        { "ヤ", new List<string> { "ya" } }, { "ユ", new List<string> { "yu" } }, { "ヨ", new List<string> { "yo" } },
        { "ラ", new List<string> { "ra" } }, { "リ", new List<string> { "ri" } }, { "ル", new List<string> { "ru" } }, { "レ", new List<string> { "re" } }, { "ロ", new List<string> { "ro" } },
        { "ワ", new List<string> { "wa" } }, { "ヲ", new List<string> { "wo" } }, { "ン", new List<string> { "n", "nn" } },

        // 点々
        { "ガ", new List<string> { "ga" } }, { "ギ", new List<string> { "gi" } }, { "グ", new List<string> { "gu" } }, { "ゲ", new List<string> { "ge" } }, { "ゴ", new List<string> { "go" } },
        { "ザ", new List<string> { "za" } }, { "ジ", new List<string> { "ji", "zi" } }, { "ズ", new List<string> { "zu" } }, { "ゼ", new List<string> { "ze" } }, { "ゾ", new List<string> { "zo" } },
        { "ダ", new List<string> { "da" } }, { "ヂ", new List<string> { "ji", "di" } }, { "ヅ", new List<string> { "zu", "du" } }, { "デ", new List<string> { "de" } }, { "ド", new List<string> { "do" } },
        { "バ", new List<string> { "ba" } }, { "ビ", new List<string> { "bi" } }, { "ブ", new List<string> { "bu" } }, { "ベ", new List<string> { "be" } }, { "ボ", new List<string> { "bo" } },
            

        // 丸
        { "パ", new List<string> { "pa" } }, { "ピ", new List<string> { "pi" } }, { "プ", new List<string> { "pu" } }, { "ぺ", new List<string> { "pe" } }, { "ポ", new List<string> { "po" } },


        // 拗音
        { "キャ", new List<string> { "kya" } }, { "キュ", new List<string> { "kyu" } }, { "キョ", new List<string> { "kyo" } },
        { "ニャ", new List<string> { "nya" } }, { "ニュ", new List<string> { "nyu" } }, { "ニョ", new List<string> { "nyo" } },
        { "シャ", new List<string> { "sha", "sya" } }, { "シュ", new List<string> { "shu", "syu" } }, { "ショ", new List<string> { "sho", "syo" } },
        { "チャ", new List<string> { "cha", "cya", "tya" } }, { "チュ", new List<string> { "chu", "cyu", "tyu" } }, { "チョ", new List<string> { "cho", "cyo", "tyo" } },
        { "ヒャ", new List<string> { "hya" } }, { "ヒュ", new List<string> { "hyu" } }, { "ヒョ", new List<string> { "hyo" } },
        { "ミャ", new List<string> { "mya" } }, { "ミュ", new List<string> { "myu" } }, { "ミョ", new List<string> { "myo" } },
        { "リャ", new List<string> { "rya" } }, { "リュ", new List<string> { "ryu" } }, { "リョ", new List<string> { "ryo" } },
        { "ギャ", new List<string> { "gya" } }, { "ギュ", new List<string> { "gyu" } }, { "ギョ", new List<string> { "gyo" } },
        { "ジャ", new List<string> { "jya", "ja", "zya" } }, { "ジュ", new List<string> { "jyu", "ju", "zyu" } }, { "ジョ", new List<string> { "jyo", "jo", "zyo" } },
        { "ヂャ", new List<string> { "jya", "dya", "ja" } }, { "ヂュ", new List<string> { "jyu", "dyu", "ju" } }, { "ヂョ", new List<string> { "jyo", "dyo", "jo" } },
        { "ビャ", new List<string> { "bya" } }, { "ビュ", new List<string> { "byu" } }, { "ビョ", new List<string> { "byo" } },
        { "ピャ", new List<string> { "pya" } }, { "ピュ", new List<string> { "pyu" } }, { "ピョ", new List<string> { "pyo" } },
    };

    // Used for Katakana Module
    public static readonly Dictionary<string, List<string>> KatakanaExtrasList = new Dictionary<string, List<string>>()
    {
        { "ヰ", new List<string> { "wyi", "wi" } },
        { "ヱ", new List<string> { "wye", "we" } },
        { "イェ", new List<string> { "ye" } },
        { "ウァ", new List<string> { "wha" } },
        { "ウィ", new List<string> { "whi", "wi" } },
        { "ウェ", new List<string> { "whe", "we" } },
        { "ウォ", new List<string> { "who" } },
        { "クァ", new List<string> { "qa" } },
        { "クィ", new List<string> { "qi" } },
        { "クェ", new List<string> { "qe" } },
        { "クォ", new List<string> { "qo" } },
        { "スァ", new List<string> { "swa" } },
        { "スィ", new List<string> { "swi" } },
        { "スゥ", new List<string> { "swu" } },
        { "スェ", new List<string> { "swe" } },
        { "スォ", new List<string> { "swo" } },
        { "ツァ", new List<string> { "tsa" } },
        { "ツィ", new List<string> { "tsi" } },
        { "ツェ", new List<string> { "tse" } },
        { "ツォ", new List<string> { "tso" } },
        { "テャ", new List<string> { "tha" } },
        { "ティ", new List<string> { "thi" } },
        { "テュ", new List<string> { "thu" } },
        { "テェ", new List<string> { "the" } },
        { "テョ", new List<string> { "tho" } },
        { "トァ", new List<string> { "twa" } },
        { "トィ", new List<string> { "twi" } },
        { "トゥ", new List<string> { "twu" } },
        { "トェ", new List<string> { "twe" } },
        { "トォ", new List<string> { "two" } },
        { "ファ", new List<string> { "fa" } },
        { "フィ", new List<string> { "fi" } },
        { "フェ", new List<string> { "fe" } },
        { "フォ", new List<string> { "fo" } },
        { "フャ", new List<string> { "fya" } },
        { "フュ", new List<string> { "fyu" } },
        { "フョ", new List<string> { "fyo" } },
        { "グァ", new List<string> { "gwa" } },
        { "グィ", new List<string> { "gwi" } },
        { "グゥ", new List<string> { "gwu" } },
        { "グェ", new List<string> { "gwe" } },
        { "グォ", new List<string> { "gwo" } },
        { "デャ", new List<string> { "dha" } },
        { "ディ", new List<string> { "dhi" } },
        { "デュ", new List<string> { "dhu" } },
        { "デェ", new List<string> { "dhe" } },
        { "デョ", new List<string> { "dho" } },
        { "ドァ", new List<string> { "dwa" } },
        { "ドィ", new List<string> { "dwi" } },
        { "ドゥ", new List<string> { "dwu" } },
        { "ドェ", new List<string> { "dwe" } },
        { "ドォ", new List<string> { "dwo" } },
        { "ヴァ", new List<string> { "va" } },
        { "ヴィ", new List<string> { "vi" } },
        { "ヴ", new List<string> { "vu" } },
        { "ヴェ", new List<string> { "ve" } },
        { "ヴォ", new List<string> { "vo" } },
        { "ヴャ", new List<string> { "vya" } },
        { "ヴュ", new List<string> { "vyu" } },
        { "ヴョ", new List<string> { "vyo" } },
    };

    // Used for Shiritori Module
    public static readonly Dictionary<string, List<string>> ShiritoriHiraganaList = new Dictionary<string, List<string>>()
    {
        // 普通
        { "あ", new List<string> { "a" } }, { "い", new List<string> { "i" } }, { "う", new List<string> { "u" } }, { "え", new List<string> { "e" } }, { "お", new List<string> { "o" } },
        { "か", new List<string> { "ka" } }, { "き", new List<string> { "ki" } }, { "く", new List<string> { "ku" } }, { "け", new List<string> { "ke" } }, { "こ", new List<string> { "ko" } },
        { "さ", new List<string> { "sa" } }, { "し", new List<string> { "shi", "si" } }, { "す", new List<string> { "su" } }, { "せ", new List<string> { "se" } }, { "そ", new List<string> { "so" } },
        { "た", new List<string> { "ta" } }, { "ち", new List<string> { "chi", "ti" } }, { "つ", new List<string> { "tsu", "tu" } }, { "て", new List<string> { "te" } }, { "と", new List<string> { "to" } },
        { "な", new List<string> { "na" } }, { "に", new List<string> { "ni" } }, { "ぬ", new List<string> { "nu" } }, { "ね", new List<string> { "ne" } }, { "の", new List<string> { "no" } },
        { "は", new List<string> { "ha" } }, { "ひ", new List<string> { "hi" } }, { "ふ", new List<string> { "fu", "hu" } }, { "へ", new List<string> { "he" } }, { "ほ", new List<string> { "ho" } },
        { "ま", new List<string> { "ma" } }, { "み", new List<string> { "mi" } }, { "む", new List<string> { "mu" } }, { "め", new List<string> { "me" } }, { "も", new List<string> { "mo" } },
        { "や", new List<string> { "ya" } }, { "ゆ", new List<string> { "yu" } }, { "よ", new List<string> { "yo" } },
        { "ら", new List<string> { "ra" } }, { "り", new List<string> { "ri" } }, { "る", new List<string> { "ru" } }, { "れ", new List<string> { "re" } }, { "ろ", new List<string> { "ro" } },
        { "わ", new List<string> { "wa" } }, { "を", new List<string> { "wo", "o" } }, { "ん", new List<string> { "nn" } },

        // 点々
        { "が", new List<string> { "ga" } }, { "ぎ", new List<string> { "gi" } }, { "ぐ", new List<string> { "gu" } }, { "げ", new List<string> { "ge" } }, { "ご", new List<string> { "go" } },
        { "ざ", new List<string> { "za" } }, { "じ", new List<string> { "ji", "zi" } }, { "ず", new List<string> { "zu" } }, { "ぜ", new List<string> { "ze" } }, { "ぞ", new List<string> { "zo" } },
        { "だ", new List<string> { "da" } }, { "ぢ", new List<string> { "ji", "di" } }, { "づ", new List<string> { "zu", "du" } }, { "で", new List<string> { "de" } }, { "ど", new List<string> { "do" } },
        { "ば", new List<string> { "ba" } }, { "び", new List<string> { "bi" } }, { "ぶ", new List<string> { "bu" } }, { "べ", new List<string> { "be" } }, { "ぼ", new List<string> { "bo" } },
            

        // 丸
        { "ぱ", new List<string> { "pa" } }, { "ぴ", new List<string> { "pi" } }, { "ぷ", new List<string> { "pu" } }, { "ぺ", new List<string> { "pe" } }, { "ぽ", new List<string> { "po" } },


        // 拗音
        { "きゃ", new List<string> { "kya" } }, { "きゅ", new List<string> { "kyu" } }, { "きょ", new List<string> { "kyo" } },
        { "にゃ", new List<string> { "nya" } }, { "にゅ", new List<string> { "nyu" } }, { "にょ", new List<string> { "nyo" } },
        { "しゃ", new List<string> { "sha", "sya" } }, { "しゅ", new List<string> { "shu", "syu" } }, { "しょ", new List<string> { "sho", "syo" } },
        { "ちゃ", new List<string> { "cha", "cya", "tya" } }, { "ちゅ", new List<string> { "chu", "cyu", "tyu" } }, { "ちょ", new List<string> { "cho", "cyo", "tyo" } },
        { "ひゃ", new List<string> { "hya" } }, { "ひゅ", new List<string> { "hyu" } }, { "ひょ", new List<string> { "hyo" } },
        { "みゃ", new List<string> { "mya" } }, { "みゅ", new List<string> { "myu" } }, { "みょ", new List<string> { "myo" } },
        { "りゃ", new List<string> { "rya" } }, { "りゅ", new List<string> { "ryu" } }, { "りょ", new List<string> { "ryo" } },
        { "ぎゃ", new List<string> { "gya" } }, { "ぎゅ", new List<string> { "gyu" } }, { "ぎょ", new List<string> { "gyo" } },
        { "じゃ", new List<string> { "jya", "ja", "zya" } }, { "じゅ", new List<string> { "jyu", "ju", "zyu" } }, { "じょ", new List<string> { "jyo", "jo", "zyo" } },
        { "ぢゃ", new List<string> { "jya", "dyu", "ja" } }, { "ぢゅ", new List<string> { "jyu", "dyu", "ju" } }, { "ぢょ", new List<string> { "jyo", "dyo", "jo" } },
        { "びゃ", new List<string> { "bya" } }, { "びゅ", new List<string> { "byu" } }, { "びょ", new List<string> { "byo" } },
        { "ぴゃ", new List<string> { "pya" } }, { "ぴゅ", new List<string> { "pyu" } }, { "ぴょ", new List<string> { "pyo" } },
    };

    // Used for Shiritori Module
    // For the player
    public static readonly List<string> ShiritoriMissingWordsList = new List<string>()
    {
        // Missing words displayed on the manual
        "あべこべ", "いざこざ", "おべっか", "おしゃぶり", "けじめ", "せっかち", "ちぐはぐ", "ちょっかい", "ときめき", "ねた", "ねじまき", "ふしだら", "まやかし", "もんぺ", "がらんどう", "ぐる", "ずれ", "でか", "びんた", "ぶれ", "べらんめえ", "ぼんやり",

        // Other
        "ずんだもち",
        "うんこ",
        "うんち",
    };

    // Used for Shiritori Module
    // For the module
    public static readonly List<string> ShiritoriBannedWordsList = new List<string>()
    {
        "うんこ", "けつのあな", "たねちがい", "ちんこ", "ちんぽこ", "つやごと", "つやだね", "みなごろし", "がいいんぶ", "げすおんな", "げすおとこ", "ばかやろう", "ちんちん", "うんち",
    };

    // Used for KakuKanji Module
    public static readonly Dictionary<string, string> KakuKanjiList = new Dictionary<string, string>()
    {
        { "家族", "かぞく" }, { "学生", "がくせい" }, { "会社", "かいしゃ" }, { "空港", "くうこう" }, { "病院", "びょういん" }, { "郵便局", "ゆうびんきょく" }, { "図書館", "としょかん" }, { "観光", "かんこう" }, { "料理", "りょうり" },
        { "映画", "えいが" }, { "天気", "てんき" }, { "新聞", "しんぶん" }, { "手紙", "てがみ" }, { "誕生日", "たんじょうび" }, { "自動車", "じどうしゃ" }, { "音楽", "おんがく" }, { "旅行", "りょこう" }, { "交通", "こうつう" },
        { "空手", "からて" }, { "数学", "すうがく" }, { "電話", "でんわ" }, { "仕事", "しごと" }, { "銀行", "ぎんこう" }, { "地図", "ちず" }, { "言葉", "ことば" },{ "飛行機", "ひこうき" }, { "教室", "きょうしつ" }, { "空気", "くうき" },
        { "趣味", "しゅみ" }, { "運動", "うんどう" }, { "時計", "とけい" }, { "課題", "かだい" }, { "野菜", "やさい" }, { "外国", "がいこく" }, { "時間", "じかん" }, { "質問", "しつもん" }, { "世界", "せかい" }, { "会議", "かいぎ" },
        { "体温", "たいおん" }, { "自動販売機", "じどうはんばいき" }, { "国際電話", "こくさいでんわ" }, { "携帯電話", "けいたいでんわ" }, { "電気製品", "でんきせいひん" }, { "消防車", "しょうぼうしゃ" }, { "動物園", "どうぶつえん" },
        { "天気予報", "てんきよほう" }, { "交通事故", "こうつうじこ" }, { "緊急出口", "きんきゅうでぐち" }, { "手洗い場", "てあらいば" },
    };

    // { "", "" },
}