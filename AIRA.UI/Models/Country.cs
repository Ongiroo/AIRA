using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public enum Country
    {
        Afghanistan	,
        Albania,
        Algeria,
        [Display(Name="American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antigua,
        Argentina,
        Armenia,
        Aruba,
        Ascensioni,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        [Display(Name = "Bosnia and Herzegovina")]
        BosniaHerzegovina,
        Botswana,
        Brazil,
        Britain,
        [Display(Name = "British Virgin Islands")]
        BritishVirginIslands,
        Brunei,
        Bulgaria,
        Burkinafaso,
        Burma,
        Burundi,
        Camaroon,
        Cambodia,
        Canada,
        [Display(Name = "Cape Verde Islands")]
        CapeVerdeIslands,
        Caymanis,
        [Display(Name = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [Display(Name = "Christmas Islands")]
        ChristmasIslands,
        Cocosis,
        Colombia,
        Comoros,
        Congo,
        [Display(Name = "Cook Island")]
        CookIsland,
        [Display(Name = "Costa Rica")]
        CostaRica,
        Croatia,
        Cuba,
        Cyprus,
        Czechoslovakia,
        [Display(Name = "Czech Republic")]
        CzechRepublic,
        Denmark,
        [Display(Name = "Diego Garcia")]
        DiegoGarcia,
        Djibouti,
        [Display(Name = "Domincan Republic")]
        DomincanRepublic,
        Dominica,
        [Display(Name = "Easter Islands")]
        EasterIslands,
        Ecuador,
        Egypt,
        ElSalvador,
        EqGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [Display(Name = "Faeroe Islands")]
        FaeroeIslands,
        [Display(Name = "Falkland Islands")]
        FalklandIslands,
        [Display(Name = "Fiji Islands")]
        FijiIslands,
        Finland,
        France,
        [Display(Name = "French Antilles")]
        FrenchAntilles,
        [Display(Name = "French Guiana")]
        FrenchGuiana,
        [Display(Name = "French Polyneisa")]
        FrenchPolyneisa,
        [Display(Name = "Futana Island")]
        FutanaIsland,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibralter,
        Greece,
        Greenland,
        Grenada,
        Grenedines,
        Guadeloupe,
        Guam,
        [Display(Name = "Guantanamo Bay")]
        GuantanamoBay,
        Guatemala,
        Guinea,
        GuineaBissau,
        Guyana,
        Haiti,
        Honduras,
        [Display(Name = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        [Display(Name = "Ivory Coast")]
        IvoryCoast,
        Jamaica,
        Japan,
        Jordan,
        Kenya,
        Kiribati,
        Korea,
        Kuwait,
        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxenbourg,
        Macao,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Display(Name = "Marshall Islands")]
        MarshallIslands,
        Mauritania,
        Mauritius,
        Mayotteis,
        Mexico,
        Micronesia,
        Miquelon,
        Moldova,
        Monaco,
        Mongolia,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Nethantilles,
        Netherlands,
        Nevis,
        [Display(Name = "New Caledonia")]
        NewCaledonia,
        [Display(Name = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [Display(Name = "Norfolk Island")]
        NorfolkIsland,
        [Display(Name = "North Korea")]
        NorthKorea,
        Norway,
        Oman,
        Pakistan,
        Palau,
        Panama,
        Paraguay,
        Peru,
        Phillippines,
        [Display(Name = "Pitcairn Island")]
        PitcairnIsland,
        [Display(Name = "Papa New Guinea")]
        PapaNewGuinea,
        Poland,
        Portugal,
        [Display(Name = "Puerto Rico")]
        PuertoRico,
        Qatar,
        Reunioni,
        Romania,
        Russia,
        Rwanda,
        Saipan,
        [Display(Name = "San Marino")]
        SanMarino,
        Saotome,
        [Display(Name = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Siberia,
        [Display(Name = "Seychelles Isand")]
        SeychellesIsand,
        Sierraleone,
        Singapore,
        Slovakia,
        Slovenia,
        [Display(Name = "Solomon Islands")]
        SolomonIslands,
        Somali,
        [Display(Name = "South Africa")]
        SouthAfrica,
        [Display(Name = "South Korea")]
        SouthKorea,
        Spain,
        Srilanka,
        Sthelena,
        Stkitts,
        [Display(Name = "St Lucia")]
        StLucia,
        [Display(Name = "St Pierre")]
        StPierre,
        [Display(Name = "St Vincent")]
        StVincent,
        Sudan,
        Suriname,
        Swaziland,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tanzania,
        Thailand,
        Tobago,
        Togo,
        [Display(Name = "Tonga Islands")]
        TongaIslands,
        Trinidad,
        Tunisia,
        Turkey,
        [Display(Name = "Turks Caicos")]
        TurksCaicos,
        Tuvalu,
        [Display(Name = "United Arab Emirates")]
        UnitedArabEmirates,
        Uganda,
        Ukraine,
        [Display(Name = "United Kingdom")]
        UnitedKingdom,
        Uruguay,
        [Display(Name = "United States of America")]
        USA,
        USSR,
        [Display(Name = "U.S.Virgin Islands")]
        USVirginIslands,
        Vanuatu,
        VaticanCity,
        Venezuela,
        Vietnam,
        Wake,
        [Display(Name = "Wallis Island")]
        WallisIsland,
        [Display(Name = "Western Sahara")]
        WesternSahara,
        [Display(Name = "Western Samoa")]
        WesternSamoa,
        Yemen,
        Yugoslavia,
        Zaire,
        Zambia,
        Zimbabwe
    }
}
