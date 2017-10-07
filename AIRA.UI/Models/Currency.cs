using System.ComponentModel.DataAnnotations;

namespace AIRA.UI.Models
{
    public enum Currency
    {
        [Display(Name = "United Arab Emirates dirham")]	
        AED,
        [Display(Name = "Afghani")]
        AFN	,
        [Display(Name = "Lek")]
        ALL	,
        [Display(Name = "Armenian Dram")]
        AMD	,
        [Display(Name = "Netherlands Antillian Guilder")]
        ANG	,
        [Display(Name = "Kwanza")]
        AOA	,
        [Display(Name = "Argentine Peso")]
        ARS	,
        [Display(Name = "Australian Dollar")]
        AUD	,
        [Display(Name = "Aruban Guilder")]
        AWG	,
        [Display(Name = "Azerbaijanian Manat")]
        AZN	,
        [Display(Name = "Convertible Marks")]
        BAM	,
        [Display(Name = "Barbados Dollar")]
        BBD	,
        [Display(Name = "Bangladeshi Taka")]
        BDT	,
        [Display(Name = "Bulgarian Lev")]
        BGN	,
        [Display(Name = "Bahraini Dinar")]
        BHD	,
        [Display(Name = "Burundian Franc")]
        BIF	,
        [Display(Name = "Bermudian Dollar (customarily known as Bermuda Dollar)")]	
        BMD	,
        [Display(Name = "Brunei Dollar")]
        BND	,
        [Display(Name = "Boliviano")]
        BOB	,
        [Display(Name = "Bolivian Mvdol (Funds code)")]
        BOV	,
        [Display(Name = "Brazilian Real")]
        BRL	,
        [Display(Name = "Bahamian Dollar")]
        BSD	,
        [Display(Name = "Ngultrum")]
        BTN	,
        [Display(Name = "Pula")]
        BWP	,
        [Display(Name = "Belarussian Ruble")]
        BYR	,
        [Display(Name = "Belize Dollar")]
        BZD	,
        [Display(Name = "Canadian Dollar")]
        CAD	,
        [Display(Name = "Franc Congolais")]
        CDF	,
        [Display(Name = "WIR Euro (complementary currency)")]
        CHE	,
        [Display(Name = "Swiss Franc")]
        CHF	,
        [Display(Name = "WIR Franc (complementary currency)")]
        CHW	,
        [Display(Name = "Unidades de formento (Funds code)")]
        CLF	,
        [Display(Name = "Chilean Peso")]
        CLP	,
        [Display(Name = "Yuan Renminbi")]
        CNY	,
        [Display(Name = "Colombian Peso")]
        COP	,
        [Display(Name = "Unidad de Valor Real")]
        COU	,
        [Display(Name = "Costa Rican Colon")]
        CRC	,
        [Display(Name = "Cuban Peso")]
        CUP	,
        [Display(Name = "Cape Verde Escudo")]
        CVE	,
        [Display(Name = "Cyprus Pound")]
        CYP	,
        [Display(Name = "Czech Koruna")]
        CZK	,
        [Display(Name = "Djibouti Franc")]
        DJF	,
        [Display(Name = "Danish Krone")]
        DKK	,
        [Display(Name = "Dominican Peso")]
        DOP	,
        [Display(Name = "Algerian Dinar")]
        DZD	,
        [Display(Name = "Kroon")]
        EEK	,
        [Display(Name = "Egyptian Pound")]
        EGP	,
        [Display(Name = "Nakfa")]
        ERN	,
        [Display(Name = "Ethiopian Birr")]
        ETB	,
        [Display(Name = "Euro")]
        EUR	,
        [Display(Name = "Fiji Dollar")]
        FJD	,
        [Display(Name = "Falkland Islands Pound")]
        FKP	,
        [Display(Name = "Pound Sterling	")]
        GBP,
        [Display(Name = "Lari")]
        GEL,
        [Display(Name = "Cedi")]
        GHS,
        [Display(Name = "Gibraltar pound")]
        GIP,
        [Display(Name = "Dalasi")]
        GMD,
        [Display(Name = "Guinea Franc")]
        GNF,
        [Display(Name = "Quetzal")]
        GTQ,
        [Display(Name = "Guyana Dollar")]
        GYD,
        [Display(Name = "Hong Kong Dollar")]
        HKD,
        [Display(Name = "Lempira")]
        HNL,
        [Display(Name = "Croatian Kuna")]
        HRK,
        [Display(Name = "Haiti Gourde")]
        HTG,
        [Display(Name = "Forint")]
        HUF,
        [Display(Name = "Rupiah	")]
        IDR,
        [Display(Name = "New Israeli Shekel")]
        ILS,
        [Display(Name = "Indian Rupee")]
        INR,
        [Display(Name = "Iraqi Dinar")]
        IQD,
        [Display(Name = "Iranian Rial")]
        IRR,
        [Display(Name = "Iceland Krona")]
        ISK,
        [Display(Name = "Jamaican Dollar")]
        JMD,
        [Display(Name = "Jordanian Dinar")]
        JOD,
        [Display(Name = "Japanese yen")]
        JPY,
        [Display(Name = "Kenyan Shilling")]
        KES,
        [Display(Name = "Som")]
        KGS,
        [Display(Name = "Riel")]
        KHR,
        [Display(Name = "Comoro Franc")]
        KMF,
        [Display(Name = "North Korean Won")]
        KPW,
        [Display(Name = "South Korean Won")]
        KRW,
        [Display(Name = "Kuwaiti Dinar")]
        KWD,
        [Display(Name = "Cayman Islands Dollar")]
        KYD,
        [Display(Name = "Tenge")]
        KZT,
        [Display(Name = "Kip")]
        LAK,
        [Display(Name = "Lebanese Pound	")]
        LBP,
        [Display(Name = "Sri Lanka Rupee	")]
        LKR,
        [Display(Name = "Liberian Dollar	")]
        LRD,
        [Display(Name = "Loti	")]
        LSL,
        [Display(Name = "Lithuanian Litas	")]
        LTL,
        [Display(Name = "Latvian Lats	")]
        LVL,
        [Display(Name = "Libyan Dinar	")]
        LYD,
        [Display(Name = "Moroccan Dirham	")]
        MAD,
        [Display(Name = "Moldovan Leu	")]
        MDL,
        [Display(Name = "Malagasy Ariary	")]
        MGA,
        [Display(Name = "Denar")]
        MKD,
        [Display(Name = "Kyat")]
        MMK,
        [Display(Name = "Tugrik")]
        MNT,
        [Display(Name = "Pataca")]
        MOP,
        [Display(Name = "Ouguiya")]
        MRO,
        [Display(Name = "Maltese Lira")]
        MTL,
        [Display(Name = "Mauritius Rupee")]
        MUR,
        [Display(Name = "Rufiyaa")]
        MVR,
        [Display(Name = "Kwacha")]
        MWK,
        [Display(Name = "Mexican Peso")]
        MXN,
        [Display(Name = "Mexican Unidad de Inversion (UDI) (Funds code)	")]
        MXV,
        [Display(Name = "Malaysian Ringgit")]
        MYR,
        [Display(Name = "Metical")]
        MZN,
        [Display(Name = "Namibian Dollar")]
        NAD,
        [Display(Name = "Naira")]
        NGN,
        [Display(Name = "Cordoba Oro")]
        NIO,
        [Display(Name = "Norwegian Krone")]
        NOK,
        [Display(Name = "Nepalese Rupee")]
        NPR,
        [Display(Name = "New Zealand Dollar")]
        NZD,
        [Display(Name = "Rial Omani")]
        OMR,
        [Display(Name = "Balboa")]
        PAB,
        [Display(Name = "Nuevo Sol")]
        PEN,
        [Display(Name = "Kina")]
        PGK,
        [Display(Name = "Philippine Peso")]
        PHP,
        [Display(Name = "Pakistan Rupee")]
        PKR,
        [Display(Name = "Zloty")]
        PLN,
        [Display(Name = "Guarani")]
        PYG,
        [Display(Name = "Qatari Rial")]
        QAR,
        [Display(Name = "Romanian New Leu")]
        RON,
        [Display(Name = "Serbian Dinar")]
        RSD,
        [Display(Name = "Russian Ruble")]
        RUB,
        [Display(Name = "Rwanda Franc")]
        RWF,
        [Display(Name = "Saudi Riyal")]
        SAR,
        [Display(Name = "Solomon Islands Dollar")]
        SBD,
        [Display(Name = "Seychelles Rupee")]
        SCR,
        [Display(Name = "Sudanese Pound")]
        SDG,
        [Display(Name = "Swedish Krona")]
        SEK,
        [Display(Name = "Singapore Dollar")]
        SGD,
        [Display(Name = "Saint Helena Pound")]
        SHP,
        [Display(Name = "Slovak Koruna")]
        SKK,
        [Display(Name = "Leone")]
        SLL,
        [Display(Name = "Somali Shilling")]
        SOS,
        [Display(Name = "Surinam Dollar	")]
        SRD,
        [Display(Name = "Dobra")]
        STD,
        [Display(Name = "Syrian Pound")]
        SYP,
        [Display(Name = "Lilangeni")]
        SZL,
        [Display(Name = "Baht")]
        THB,
        [Display(Name = "Somoni")]
        TJS,
        [Display(Name = "Manat")]
        TMM,
        [Display(Name = "Tunisian Dinar	")]
        TND,
        [Display(Name = "Pa'anga	")]
        TOP,
        [Display(Name = "New Turkish Lira	")]
        TRY,
        [Display(Name = "Trinidad and Tobago Dollar	")]
        TTD,
        [Display(Name = "New Taiwan Dollar")]
        TWD,
        [Display(Name = "Tanzanian Shilling	")]
        TZS,
        [Display(Name = "Hryvnia")]
        UAH,
        [Display(Name = "Uganda Shilling")]
        UGX,
        [Display(Name = "US Dollar")]
        USD,
        [Display(Name = "US Dollar")]
        USN,
        [Display(Name = "US Dollar")]
        USS,
        [Display(Name = "Peso Uruguayo")]
        UYU,
        [Display(Name = "Uzbekistan Som")]
        UZS,
        [Display(Name = "Venezuelan bolívar	")]
        VEB,
        [Display(Name = "Vietnamese đồng")]
        VND,
        [Display(Name = "Vatu")]
        VUV,
        [Display(Name = "Samoan Tala")]
        WST,
        [Display(Name = "CFA Franc BEAC")]
        XAF,
        [Display(Name = "Silver (one Troy ounce)")]
        XAG,
        [Display(Name = "Gold (one Troy ounce)")]
        XAU,
        [Display(Name = "European Composite Unit (EURCO) (Bonds market unit)")]
        XBA,
        [Display(Name = "European Monetary Unit (E.M.U.-6) (Bonds market unit)")]
        XBB,
        [Display(Name = "European Unit of Account 9 (E.U.A.-9) (Bonds market unit)")]
        XBC,
        [Display(Name = "European Unit of Account 17 (E.U.A.-17) (Bonds market unit)")]
        XBD,
        [Display(Name = "East Caribbean Dollar")]
        XCD,
        [Display(Name = "Special Drawing Rights")]
        XDR,
        [Display(Name = "Gold franc (special settlement currency)")]
        XFO,
        [Display(Name = "UIC franc (special settlement currency)")]
        XFU,
        [Display(Name = "CFA Franc BCEAO")]
        XOF,
        [Display(Name = "Palladium (one Troy ounce)")]
        XPD,
        [Display(Name = "CFP franc")]
        XPF,
        [Display(Name = "Platinum (one Troy ounce)")]
        XPT,
        [Display(Name = "Code reserved for testing purposes")]
        XTS,
        [Display(Name = "No currency")]
        XXX,
        [Display(Name = "Yemeni Rial")]
        YER,
        [Display(Name = "South African Rand")]
        ZAR,
        [Display(Name = "Kwacha")]
        ZMK,
        [Display(Name = "Zimbabwe Dollar")]
        ZWD
    }
}