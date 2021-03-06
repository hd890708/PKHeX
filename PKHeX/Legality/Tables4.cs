﻿using System.Linq;

namespace PKHeX.Core
{
    public static partial class Legal
    {
        internal const int MaxSpeciesIndex_4_DP = 500;
        internal const int MaxSpeciesIndex_4_HGSSPt = 507;
        internal const int MaxSpeciesID_4 = 493;
        internal const int MaxMoveID_4 = 467;
        internal const int MaxItemID_4_DP = 464;
        internal const int MaxItemID_4_Pt = 467;
        internal const int MaxItemID_4_HGSS = 536;
        internal const int MaxAbilityID_4 = 123;
        internal const int MaxBallID_4 = 0x18;

        internal static readonly int[] Met_HGSS_0 =
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
            19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45,
            46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72,
            73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99,
            100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121,
            122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143,
            144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165,
            166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187,
            188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209,
            210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231,
            232, 233, 234,
        };

        internal static readonly int[] Met_HGSS_2 =
        {
            2000, 2001, 2002, 2003, 2004, 2005, 2006, 2008, 2009, 2010, 2011,
            2012, 2013, 2014,
        };

        internal static readonly int[] Met_HGSS_3 =
        {
            3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010,
            3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028,
            3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046,
            3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064,
            3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076
        };

        #region DP
        internal static readonly ushort[] Pouch_Items_DP = {
            68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 135, 136, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327
        };
        internal static readonly ushort[] Pouch_Key_DP = {
            428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464
        };
        internal static readonly ushort[] Pouch_TMHM_DP = {
            328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427
        };
        internal static readonly ushort[] Pouch_Mail_DP = {
            137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148
        };
        internal static readonly ushort[] Pouch_Medicine_DP = {
            17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54
        };
        internal static readonly ushort[] Pouch_Berries_DP = {
            149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212
        };
        internal static readonly ushort[] Pouch_Ball_DP = {
            1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
        };
        internal static readonly ushort[] Pouch_Battle_DP = {
            55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67
        };
        internal static readonly ushort[] HeldItems_DP = new ushort[1].Concat(Pouch_Items_DP).Concat(Pouch_Mail_DP).Concat(Pouch_Medicine_DP).Concat(Pouch_Berries_DP).Concat(Pouch_Ball_DP).Concat(Pouch_TMHM_DP.Take(Pouch_TMHM_DP.Length - 8)).ToArray();
        #endregion

        #region Pt
        internal static readonly ushort[] Pouch_Items_Pt = {
            68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 135, 136, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327
        };
        internal static readonly ushort[] Pouch_Key_Pt = {
            428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467
        };
        internal static readonly ushort[] Pouch_TMHM_Pt = Pouch_TMHM_DP;
        internal static readonly ushort[] Pouch_Mail_Pt = Pouch_Mail_DP;
        internal static readonly ushort[] Pouch_Medicine_Pt = Pouch_Medicine_DP;
        internal static readonly ushort[] Pouch_Berries_Pt = Pouch_Berries_DP;
        internal static readonly ushort[] Pouch_Ball_Pt = Pouch_Ball_DP;
        internal static readonly ushort[] Pouch_Battle_Pt = Pouch_Battle_DP;

        internal static readonly ushort[] HeldItems_Pt = new ushort[1].Concat(Pouch_Items_Pt).Concat(Pouch_Mail_Pt).Concat(Pouch_Medicine_Pt).Concat(Pouch_Berries_Pt).Concat(Pouch_Ball_Pt).Concat(Pouch_TMHM_Pt.Take(Pouch_TMHM_Pt.Length - 8)).ToArray();
        #endregion

        #region HGSS
        internal static readonly ushort[] Pouch_Items_HGSS = Pouch_Items_Pt;
        internal static readonly ushort[] Pouch_Key_HGSS = {
            434, 435, 437, 444, 445, 446, 447, 450, 456, 464, 465, 466, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 501, 502, 503, 504, 532, 533, 534, 535, 536
        };
        internal static readonly ushort[] Pouch_TMHM_HGSS = Pouch_TMHM_DP;
        internal static readonly ushort[] Pouch_Mail_HGSS = Pouch_Mail_DP;
        internal static readonly ushort[] Pouch_Medicine_HGSS = Pouch_Medicine_DP;
        internal static readonly ushort[] Pouch_Berries_HGSS = Pouch_Berries_DP;
        internal static readonly ushort[] Pouch_Ball_HGSS = {
            1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 492, 493, 494, 495, 496, 497, 498, 499, 500
        };
        internal static readonly ushort[] Pouch_Battle_HGSS = Pouch_Battle_DP;

        internal static readonly ushort[] HeldItems_HGSS = new ushort[1].Concat(Pouch_Items_HGSS).Concat(Pouch_Mail_HGSS).Concat(Pouch_Medicine_HGSS).Concat(Pouch_Berries_HGSS).Concat(Pouch_Ball_Pt).Concat(Pouch_TMHM_HGSS.Take(Pouch_TMHM_HGSS.Length - 8)).ToArray();
        #endregion

        internal static readonly int[] TM_4 =
        {
            264, 337, 352, 347, 046, 092, 258, 339, 331, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 202, 219,
            218, 076, 231, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 351, 053, 188, 201, 126, 317, 332,
            259, 263, 290, 156, 213, 168, 211, 285, 289, 315,
            355, 411, 412, 206, 362, 374, 451, 203, 406, 409,
            261, 318, 373, 153, 421, 371, 278, 416, 397, 148,
            444, 419, 086, 360, 014, 446, 244, 445, 399, 157,
            404, 214, 363, 398, 138, 447, 207, 365, 369, 164,
            430, 433,
        };

        internal static readonly int[] HM_HGSS =
        {
            015, 019, 057, 070, 250, 249, 127, 431 // Defog(DPPt) & Whirlpool(HGSS)
        };

        internal static readonly int[] HM_DPPt =
        {
            015, 019, 057, 070, 432, 249, 127, 431 // Defog(DPPt) & Whirlpool(HGSS)
        };


        internal static readonly int[] HM_4_RemovePokeTransfer =
        {
            015, 019, 057, 070, 249, 127, 431 // Defog(DPPt) & Whirlpool(HGSS) excluded
        };

        internal static readonly int[] MovePP_DP =
        {
            00,
            35, 25, 10, 15, 20, 20, 15, 15, 15, 35, 30, 05, 10, 30, 30, 35, 35, 20, 15, 20, 20, 15, 20, 30, 05, 25, 15, 15, 15, 25, 20, 05, 35, 15, 20, 20, 20, 15, 30, 35, 20, 20, 30, 25, 40, 20, 15, 20, 20, 20,
            30, 25, 15, 30, 25, 05, 15, 10, 05, 20, 20, 20, 05, 35, 20, 25, 20, 20, 20, 15, 25, 15, 10, 40, 25, 10, 35, 30, 15, 20, 40, 10, 15, 30, 15, 20, 10, 15, 10, 05, 10, 10, 25, 10, 20, 40, 30, 30, 20, 20,
            15, 10, 40, 15, 10, 30, 20, 20, 10, 40, 40, 30, 30, 30, 20, 30, 10, 10, 20, 05, 10, 30, 20, 20, 20, 05, 15, 10, 20, 15, 15, 35, 20, 15, 10, 20, 30, 15, 40, 20, 15, 10, 05, 10, 30, 10, 15, 20, 15, 40,
            40, 10, 05, 15, 10, 10, 10, 15, 30, 30, 10, 10, 20, 10, 01, 01, 10, 10, 10, 05, 15, 25, 15, 10, 15, 30, 05, 40, 15, 10, 25, 10, 30, 10, 20, 10, 10, 10, 10, 10, 20, 05, 40, 05, 05, 15, 05, 10, 05, 15,
            10, 10, 10, 20, 20, 40, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25, 20, 05, 30, 05, 10, 20, 40, 05, 20, 40, 20, 15, 35, 10, 05, 05, 05, 15, 05, 20, 05, 05, 15, 20, 10, 05, 05, 15, 15, 15, 15,
            10, 10, 10, 20, 10, 10, 10, 10, 15, 15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10, 15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10, 15,
            20, 15, 10, 10, 15, 10, 05, 05, 10, 15, 10, 05, 20, 25, 05, 40, 10, 05, 40, 15, 20, 20, 05, 15, 20, 30, 15, 15, 05, 10, 30, 20, 30, 15, 05, 40, 15, 05, 20, 05, 15, 25, 40, 15, 20, 15, 20, 15, 20, 10,
            20, 20, 05, 05, 10, 05, 40, 10, 10, 05, 10, 10, 15, 10, 20, 30, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10, 10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 15, 10, 20, 20, 20, 15, 15,
            10, 15, 20, 15, 10, 10, 10, 20, 05, 30, 05, 10, 15, 10, 10, 05, 20, 30, 10, 30, 15, 15, 15, 15, 30, 10, 20, 15, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05, 20, 05, 15, 20, 05, 20, 20, 20, 20, 10, 20,
            10, 15, 20, 15, 10, 10, 05, 10, 05, 05, 10, 05, 05, 10, 05, 05, 05,
        };
        internal static readonly int[] WildPokeBalls4_DPPt =
        {
            1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            // Cherish ball not usable
        };
        internal static readonly int[] WildPokeBalls4_HGSS =
        {
            1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            // Cherish ball not usable
            17, 18, 19, 20, 21, 22,
            // Comp Ball not usable in wild
        };

        internal static readonly int[] FutureEvolutionsGen4 =
        {
            700
        };
        internal static readonly int[] UnreleasedItems_4 =
        {
            // todo
        };
        internal static readonly bool[] ReleasedHeldItems_4 = Enumerable.Range(0, MaxItemID_4_HGSS+1).Select(i => HeldItems_HGSS.Contains((ushort)i) && !UnreleasedItems_4.Contains(i)).ToArray();
        internal static readonly int[] CrownBeasts = {251, 243, 244, 245};

        internal static readonly int[] Tutors_4 =
        {
            291, 189, 210, 196, 205, 009, 007, 276,
            008, 442, 401, 466, 380, 173, 180, 314,
            270, 283, 200, 246, 235, 324, 428, 410,
            414, 441, 239, 402, 334, 393, 387, 340,
            271, 257, 282, 389, 129, 253, 162, 220,
            081, 366, 356, 388, 277, 272, 215, 067,
            143, 335, 450,
        };

        internal static readonly int[] SpecialTutors_4 =
        {
            307, 308, 338, 434
        };

        internal static readonly int[][] SpecialTutors_Compatibility_4 =
        {
            new[] { 006, 157, 257, 392 },
            new[] { 009, 160, 260, 395 },
            new[] { 003, 154, 254, 389 },
            new[] { 147, 148, 149, 230, 329, 330, 334, 371, 372, 373, 380, 381, 384, 443, 444, 445, 483, 484, 487 }
        };

        internal static readonly int[] Roaming_MetLocation_DPPt =
        {
            // Route 201-222 can be encountered in either grass or water
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
            26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
            36, 37, 
            47,     // Valley Windworks
            49,     // Fuego Ironworks
        };
        internal static readonly EncounterStatic[] Encounter_DPPt_Roam =
        {
            new EncounterStatic { Species = 481, Level = 50, Roaming = true }, //Mesprit
            new EncounterStatic { Species = 488, Level = 50, Roaming = true }, //Cresselia
            new EncounterStatic { Species = 144, Level = 60, Version = GameVersion.Pt, Roaming = true }, //Articuno
            new EncounterStatic { Species = 145, Level = 60, Version = GameVersion.Pt, Roaming = true }, //Zapdos
            new EncounterStatic { Species = 146, Level = 60, Version = GameVersion.Pt, Roaming = true }, //Moltres
        };

        internal static readonly EncounterStatic[] Encounter_DPPt_Regular =
        {
            //Starters
            new EncounterStatic { Gift = true, Species = 387, Level = 5, Location = 076, Version = GameVersion.DP,}, // Turtwig @ Lake Verity
            new EncounterStatic { Gift = true, Species = 390, Level = 5, Location = 076, Version = GameVersion.DP,}, // Chimchar
            new EncounterStatic { Gift = true, Species = 393, Level = 5, Location = 076, Version = GameVersion.DP,}, // Piplup
            new EncounterStatic { Gift = true, Species = 387, Level = 5, Location = 016, Version = GameVersion.Pt,}, // Turtwig @ Route 201
            new EncounterStatic { Gift = true, Species = 390, Level = 5, Location = 016, Version = GameVersion.Pt,}, // Chimchar
            new EncounterStatic { Gift = true, Species = 393, Level = 5, Location = 016, Version = GameVersion.Pt,}, // Piplup

            //Fossil @ Mining Museum
            new EncounterStatic { Gift = true, Species = 138, Level = 20, Location = 094, }, // Omanyte
            new EncounterStatic { Gift = true, Species = 140, Level = 20, Location = 094, }, // Kabuto
            new EncounterStatic { Gift = true, Species = 142, Level = 20, Location = 094, }, // Aerodactyl
            new EncounterStatic { Gift = true, Species = 345, Level = 20, Location = 094, }, // Lileep
            new EncounterStatic { Gift = true, Species = 347, Level = 20, Location = 094, }, // Anorith
            new EncounterStatic { Gift = true, Species = 408, Level = 20, Location = 094, }, // Cranidos
            new EncounterStatic { Gift = true, Species = 410, Level = 20, Location = 094, }, // Shieldon

            //Gift
            new EncounterStatic { Gift = true, Species = 133, Level = 05, Location = 010, Version = GameVersion.DP,}, //Eevee @ Hearthome City 
            new EncounterStatic { Gift = true, Species = 133, Level = 20, Location = 010, Version = GameVersion.Pt,}, //Eevee @ Hearthome City 
            new EncounterStatic { Gift = true, Species = 137, Level = 25, Location = 012, Version = GameVersion.Pt,}, //Porygon @ Veilstone City
            new EncounterStatic { Gift = true, Species = 175, Level = 01, EggLocation = 2011, Version = GameVersion.Pt,}, //Togepi Egg from Cynthia
            new EncounterStatic { Gift = true, Species = 440, Level = 01, EggLocation = 2009, Version = GameVersion.DP,}, //Happiny Egg from Traveling Man
            new EncounterStatic { Gift = true, Species = 447, Level = 01, EggLocation = 2010,}, //Riolu Egg from Riley

            //Stationary Lengerdary
            new EncounterStatic { Species = 377, Level = 30, Location = 125, Version = GameVersion.Pt,}, //Regirock @ Rock Peak Ruins
            new EncounterStatic { Species = 378, Level = 30, Location = 124, Version = GameVersion.Pt,}, //Regice @ Iceberg Ruins
            new EncounterStatic { Species = 379, Level = 30, Location = 123, Version = GameVersion.Pt,}, //Registeel @ Iron Ruins
            new EncounterStatic { Species = 480, Level = 50, Location = 078,}, //Uxie @ Lake Acuity
            new EncounterStatic { Species = 482, Level = 50, Location = 077,}, //Azelf @ Lake Valor
            new EncounterStatic { Species = 483, Level = 47, Location = 051, Version = GameVersion.D,}, //Dialga @ Spear Pillar
            new EncounterStatic { Species = 483, Level = 70, Location = 051, Version = GameVersion.Pt,}, //Dialga @ Spear Pillar
            new EncounterStatic { Species = 484, Level = 47, Location = 051, Version = GameVersion.P,}, //Palkia @ Spear Pillar
            new EncounterStatic { Species = 484, Level = 70, Location = 051, Version = GameVersion.Pt,}, //Palkia @ Spear Pillar
            new EncounterStatic { Species = 485, Level = 70, Location = 084, Version = GameVersion.DP,}, //Heatran @ Stark Mountain
            new EncounterStatic { Species = 485, Level = 50, Location = 084, Version = GameVersion.Pt,}, //Heatran @ Stark Mountain
            new EncounterStatic { Species = 486, Level = 70, Location = 064, Version = GameVersion.DP,}, //Regigigas @ Snowpoint Temple
            new EncounterStatic { Species = 486, Level = 01, Location = 064, Version = GameVersion.Pt,}, //Regigigas @ Snowpoint Temple
            new EncounterStatic { Species = 487, Level = 70, Location = 062, Version = GameVersion.DP, Form = 0, }, //Giratina @ Turnback Cave
            new EncounterStatic { Species = 487, Level = 47, Location = 117, Version = GameVersion.Pt, Form = 1, }, //Giratina @ Distortion World
            new EncounterStatic { Species = 487, Level = 47, Location = 062, Version = GameVersion.Pt, Form = 0, }, //Giratina @ Turnback Cave

            //Event
            new EncounterStatic { Species = 490, Level = 01, EggLocation = 3001, Fateful = true, Gift = true }, //Manaphy from Pokemon Ranger
            new EncounterStatic { Species = 491, Level = 40, Location = 079, Version = GameVersion.DP,}, //Darkrai @ Newmoon Island
            new EncounterStatic { Species = 491, Level = 50, Location = 079, Version = GameVersion.Pt,}, //Darkrai @ Newmoon Island
            new EncounterStatic { Species = 492, Form = 0, Level = 30, Location = 063,}, //Shaymin @ Flower Paradise
            //new EncounterStatic { Species = 493, Level = 80, Location = 086,}, //Arceus @ Hall of Origin
        };

        internal static readonly EncounterStatic[] Encounter_DPPt = Encounter_DPPt_Roam.SelectMany(e => e.Clone(Roaming_MetLocation_DPPt)).Concat(Encounter_DPPt_Regular).ToArray();

        internal static readonly int[] Roaming_MetLocation_HGSS_Johto =
        {
            // Route 29-48 can be encountered in either grass or water
            177,178,179,180,181,182,183,184,185,186,
            187,        190,191,192,193,194,        // Won't go to route 40,41,47,48
        };
        internal static readonly EncounterStatic[] Encounter_HGSS_JohtoRoam =
        {
            new EncounterStatic { Species = 243, Level = 40, Roaming = true }, // Raikou
            new EncounterStatic { Species = 244, Level = 40, Roaming = true }, // Entei
        };

        internal static readonly int[] Roaming_MetLocation_HGSS_Kanto =
        {
            // Route 01-28 can be encountered in either grass or water
            149,150,151,152,153,154,155,156,157,158,
            159,160,161,162,163,164,165,166,167,168,
            169,170,    172,    174,    176,        // Won't go to route 23 25 27
        };
        internal static readonly EncounterStatic[] Encounter_HGSS_KantoRoam =
        {
            new EncounterStatic { Species = 380, Level = 35, Version = GameVersion.HG, Roaming = true }, //Latias
            new EncounterStatic { Species = 381, Level = 35, Version = GameVersion.SS, Roaming = true }, //Latios
        };

        internal static readonly EncounterStatic[] Encounter_HGSS_Regular =
        {
            //Starters
            new EncounterStatic { Gift = true, Species = 001, Level = 05, Location = 138, }, // Bulbasaur @ Pallet Town
            new EncounterStatic { Gift = true, Species = 004, Level = 05, Location = 138, }, // Charmander
            new EncounterStatic { Gift = true, Species = 009, Level = 05, Location = 138, }, // Squirtle
            new EncounterStatic { Gift = true, Species = 152, Level = 05, Location = 126, }, // Chikorita @ New Bark Town
            new EncounterStatic { Gift = true, Species = 155, Level = 05, Location = 126, }, // Cyndaquil
            new EncounterStatic { Gift = true, Species = 158, Level = 05, Location = 126, }, // Totodile
            new EncounterStatic { Gift = true, Species = 252, Level = 05, Location = 148, }, // Treecko @ Saffron City
            new EncounterStatic { Gift = true, Species = 255, Level = 05, Location = 148, }, // Torchic
            new EncounterStatic { Gift = true, Species = 258, Level = 05, Location = 148, }, // Mudkip

            //Fossil @ Pewter City
            new EncounterStatic { Gift = true, Species = 138, Level = 20, Location = 140, }, // Omanyte
            new EncounterStatic { Gift = true, Species = 140, Level = 20, Location = 140, }, // Kabuto
            new EncounterStatic { Gift = true, Species = 142, Level = 20, Location = 140, }, // Aerodactyl
            new EncounterStatic { Gift = true, Species = 345, Level = 20, Location = 140, }, // Lileep
            new EncounterStatic { Gift = true, Species = 347, Level = 20, Location = 140, }, // Anorith
            new EncounterStatic { Gift = true, Species = 408, Level = 20, Location = 140, }, // Cranidos
            new EncounterStatic { Gift = true, Species = 410, Level = 20, Location = 140, }, // Shieldon

            //Gift
            new EncounterStatic { Gift = true, Species = 133, Level = 05, Location = 131, }, // Eevee @ Goldenrod City
            new EncounterStatic { Gift = true, Species = 147, Level = 15, Location = 222, Moves = new[] {245, 086, 239, 082}, }, // Dratini @ Dragon's Den (ExtremeSpeed)
            new EncounterStatic { Gift = true, Species = 147, Level = 15, Location = 222, Moves = new[] {043, 086, 239, 082}, }, // Dratini @ Dragon's Den (Non-ExtremeSpeed)
            new EncounterStatic { Gift = true, Species = 236, Level = 10, Location = 216, }, // Tyrogue @ Mt. Mortar
            new EncounterStatic { Gift = true, Species = 175, Level = 01, EggLocation = 2013, Moves = new[] {045, 204, 326, -1},}, // Togepi Egg from Mr. Pokemon (Extrasensory as Egg move)
            new EncounterStatic { Gift = true, Species = 179, Level = 01, EggLocation = 2014,}, // Mareep Egg from Primo
            new EncounterStatic { Gift = true, Species = 194, Level = 01, EggLocation = 2014,}, // Wooper Egg from Primo
            new EncounterStatic { Gift = true, Species = 218, Level = 01, EggLocation = 2014,}, // Slugma Egg from Primo
            new EncounterStatic { Gift = true, Species = 490, Level = 01, EggLocation = 3001, Fateful = true, }, //Manaphy from Pokemon Ranger

            //Stationary
            new EncounterStatic { Species = 130, Level = 30, Location = 135, Shiny = true }, //Gyarados @ Lake of Rage
            new EncounterStatic { Species = 131, Level = 20, Location = 210, }, //Lapras @ Union Cave Friday Only
            new EncounterStatic { Species = 143, Level = 50, Location = 159, }, //Snorlax @ Route 11
            new EncounterStatic { Species = 143, Level = 50, Location = 160, }, //Snorlax @ Route 12
            new EncounterStatic { Species = 185, Level = 20, Location = 184, }, //Sudowoodo @ Route 36

            //Stationary Lengerdary
            new EncounterStatic { Species = 144, Level = 50, Location = 203, }, //Articuno @ Seafoam Islands
            new EncounterStatic { Species = 145, Level = 50, Location = 158, }, //Zapdos @ Route 10
            new EncounterStatic { Species = 146, Level = 50, Location = 137, }, //Moltres @ Mt. Silver
            new EncounterStatic { Species = 150, Level = 70, Location = 199, }, //Mewtwo @ Cerulean Cave
            new EncounterStatic { Species = 245, Level = 40, Location = 173, }, //Suicune @ Route 25
            new EncounterStatic { Species = 245, Level = 40, Location = 206, }, //Suicune @ Burned Tower
            new EncounterStatic { Species = 249, Level = 45, Location = 218, Version = GameVersion.SS, }, //Lugia @ Whirl Islands
            new EncounterStatic { Species = 249, Level = 70, Location = 218, Version = GameVersion.HG, }, //Lugia @ Whirl Islands
            new EncounterStatic { Species = 250, Level = 45, Location = 205, Version = GameVersion.HG, }, //Ho-Oh @ Bell Tower
            new EncounterStatic { Species = 250, Level = 70, Location = 205, Version = GameVersion.SS, }, //Ho-Oh @ Bell Tower
            new EncounterStatic { Species = 380, Level = 40, Location = 140, Version = GameVersion.SS, }, //Latias @ Pewter City
            new EncounterStatic { Species = 381, Level = 40, Location = 140, Version = GameVersion.HG, }, //Latios @ Pewter City
            new EncounterStatic { Species = 382, Level = 50, Location = 232, Version = GameVersion.HG, }, //Kyogre @ Embedded Tower
            new EncounterStatic { Species = 383, Level = 50, Location = 232, Version = GameVersion.SS, }, //Groudon @ Embedded Tower
            new EncounterStatic { Species = 384, Level = 50, Location = 232, }, //Rayquaza @ Embedded Tower
            new EncounterStatic { Species = 483, Level = 01, Location = 231, }, //Dialga @ Sinjoh Ruins
            new EncounterStatic { Species = 484, Level = 01, Location = 231, }, //Palkia @ Sinjoh Ruins
            new EncounterStatic { Species = 487, Level = 01, Location = 231, Form = 1}, //Giratina @ Sinjoh Ruins
        };

        internal static readonly EncounterStatic[] Encounter_HGSS = Encounter_HGSS_KantoRoam.SelectMany(e => e.Clone(Roaming_MetLocation_HGSS_Kanto)).Concat(
                                                                    Encounter_HGSS_JohtoRoam.SelectMany(e => e.Clone(Roaming_MetLocation_HGSS_Johto))).Concat(
                                                                    Encounter_HGSS_Regular).ToArray();

        internal static readonly EncounterTrade[] TradeGift_DPPt =
        {
            new EncounterTrade { Species = 063, Ability = 1, TID = 25643, SID = 00000, OTGender = 1, Gender = 0, IVs = new[] {15,15,15,25,25,20}, Nature = Nature.Quiet,}, // Abra
            new EncounterTrade { Species = 441, Ability = 2, TID = 44142, SID = 00000, OTGender = 0, Gender = 1, IVs = new[] {15,20,15,25,15,25}, Nature = Nature.Lonely, Contest = new[] {20,20,20,20,20,0} }, // Chatot
            new EncounterTrade { Species = 093, Ability = 1, TID = 19248, SID = 00000, OTGender = 1, Gender = 0, IVs = new[] {20,25,15,15,15,25}, Nature = Nature.Hasty,}, // Haunter
            new EncounterTrade { Species = 129, Ability = 1, TID = 53277, SID = 00000, OTGender = 0, Gender = 1, IVs = new[] {15,25,15,25,15,20}, Nature = Nature.Mild}, // Magikarp
        };
        internal static readonly EncounterTrade[] TradeGift_HGSS =
        {
            new EncounterTrade { Species = 095, Ability = 2, TID = 48926, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {25,20,25,15,15,15}, Nature = Nature.Hasty,}, // Onix
            new EncounterTrade { Species = 066, Ability = 1, TID = 37460, SID = 00000, OTGender = 0, Gender = 1, IVs = new[] {15,25,20,15,15,20}, Nature = Nature.Lonely,}, // Machop
            new EncounterTrade { Species = 100, Ability = 2, TID = 29189, SID = 00000, OTGender = 0, Gender = 2, IVs = new[] {15,20,15,25,15,25}, Nature = Nature.Hardy,}, // Voltorb
            new EncounterTrade { Species = 085, Ability = 1, TID = 00283, SID = 00000, OTGender = 1, Gender = 1, IVs = new[] {20,20,20,15,15,15}, Nature = Nature.Impish,}, // Dodrio
            new EncounterTrade { Species = 082, Ability = 1, TID = 50082, SID = 00000, OTGender = 0, Gender = 2, IVs = new[] {15,20,15,20,20,20}, Nature = Nature.Impish,}, // Magneton
            new EncounterTrade { Species = 178, Ability = 1, TID = 15616, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {15,20,15,20,20,20}, Nature = Nature.Modest,}, // Xatu
            new EncounterTrade { Species = 025, Ability = 1, TID = 33038, SID = 00000, OTGender = 0, Gender = 1, IVs = new[] {20,25,18,25,13,31}, Nature = Nature.Jolly,}, // Pikachu
            new EncounterTrade { Species = 374, Ability = 1, TID = 23478, SID = 00000, OTGender = 0, Gender = 2, IVs = new[] {28,29,24,24,25,23}, Nature = Nature.Brave,}, // Beldum
            new EncounterTrade { Species = 111, Ability = 1, TID = 06845, SID = 00000, OTGender = 0, Gender = 1, IVs = new[] {22,31,13,22,09,00}, Nature = Nature.Relaxed, Moves= new[]{422,-1,-1,-1} }, // Rhyhorn
            new EncounterTrade { Species = 208, Ability = 1, TID = 26491, SID = 00000, OTGender = 1, Gender = 0, IVs = new[] {08,30,28,18,20,06}, Nature = Nature.Brave,}, // Steelix

            //Gift
            new EncounterTrade { Species = 021, Ability = 1, TID = 01001, SID = 00000, OTGender = 0, Gender = 1, Nature = Nature.Hasty,   Level = 20, Location = 183, Moves= new[]{043,031,228,332}},//Webster's Spearow
            new EncounterTrade { Species = 213, Ability = 2, TID = 04336, SID = 00000, OTGender = 0, Gender = 1, Nature = Nature.Relaxed, Level = 20, Location = 130, Moves= new[]{132,117,227,219}},//Kirk's Shuckle
        };

        // Encounter Slots that are replaced
        internal static readonly int[] Slot4_Time = {2, 3};
        internal static readonly int[] Slot4_Sound = {4, 5};
        internal static readonly int[] Slot4_Radar = {6, 7, 10, 11};
        internal static readonly int[] Slot4_Dual = {8, 9};
        #region Alt Slots
        private static readonly EncounterArea[] SlotsDPPPtAlt =
        {
            new EncounterArea {
                Location = 50, // Mount Coronet
                Slots = new[]
                {
                     new EncounterSlot { Species = 349, LevelMin = 10, LevelMax = 20, Type = SlotType.Old_Rod }, // Feebas
                     new EncounterSlot { Species = 349, LevelMin = 10, LevelMax = 20, Type = SlotType.Good_Rod }, // Feebas
                     new EncounterSlot { Species = 349, LevelMin = 10, LevelMax = 20, Type = SlotType.Super_Rod }, // Feebas
                },},
            new EncounterArea {
                Location = 53, // Solaceon Ruins
                Slots = new int[25].Select((s, i) => new EncounterSlot { Species = 201, LevelMin = 14, LevelMax = 30, Type = SlotType.Grass, Form = i+1 }).ToArray() // B->?, Unown A is loaded from encounters raw file
            },
        };
        private static readonly EncounterArea[] SlotsHGSSAlt =
        {
            new EncounterArea {
                Location = 209, // Ruins of Alph
                Slots = new int[25].Select((s, i) => new EncounterSlot { Species = 201, LevelMin = 5, LevelMax = 5, Type = SlotType.Grass, Form = i+1 }).ToArray() // B->?, Unown A is loaded from encounters raw file
            },
        };

        private static readonly EncounterArea SlotsPt_HoneyTree =
            new EncounterArea
            {
                Slots = new[]
                {
                    new EncounterSlot { Species = 190, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Aipom 
                    new EncounterSlot { Species = 214, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Heracross
                    new EncounterSlot { Species = 265, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Wurmple
                    new EncounterSlot { Species = 412, LevelMin = 5, LevelMax = 15, Form = 0, Type = SlotType.HoneyTree }, // Burmy Plant Cloak
                    new EncounterSlot { Species = 415, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Combee 
                    new EncounterSlot { Species = 420, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Cheruby
                    new EncounterSlot { Species = 446, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Munchlax 
                },
            };

        private static readonly EncounterArea SlotsD_HoneyTree =
            new EncounterArea {
                Slots = SlotsPt_HoneyTree.Slots.Concat( new[]
                {
                    new EncounterSlot { Species = 266, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Silcoon
                }).ToArray()
        };

        private static readonly EncounterArea SlotsP_HoneyTree =
            new EncounterArea
            {
                Slots = SlotsPt_HoneyTree.Slots.Concat(new[]
                {
                    new EncounterSlot { Species = 268, LevelMin = 5, LevelMax = 15, Type = SlotType.HoneyTree }, // Cascoon
                }).ToArray()
            };

        private static readonly int[] Shellos_EastSeaLocation_DP =
        {
            28, // Route 213
            39, // Route 224
        };

        private static readonly int[] Shellos_EastSeaLocation_Pt =
        {
            11, // Pastoria City
            27, // Route 212
            28, // Route 213
        };

        private static readonly int[] Gastrodon_EastSeaLocation_DP =
        {
            37, // Route 222
            39, // Route 224
            45, // Route 230
        };

        private static readonly int[] Gastrodon_EastSeaLocation_Pt =
        {
            11, // Pastoria City
            27, // Route 212
            28, // Route 213
            39, // Route 224
            45, // Route 230
        };

        private static readonly int[] HoneyTreesLocation =
        {
            20, // Route 205
            21, // Route 206
            22, // Route 207
            23, // Route 208
            24, // Route 209
            25, // Route 210
            26, // Route 211 
            27, // Route 212 
            28, // Route 213
            29, // Route 214
            30, // Route 215
            33, // Route 218
            36, // Route 221
            37, // Route 222
            47, // Valley Windworks 
            49, // Fuego Ironworks
            58, //Floaroma Meadow
        };

        private static readonly EncounterArea[] SlotsDPPT_Swarm =
        {
            //reference http://bulbapedia.bulbagarden.net/wiki/Pokémon_outbreak
            new EncounterArea {Location = 016, Slots = new[]{new EncounterSlot {Species = 084, Type = SlotType.Grass }, },},// Doduo @ Route 201
            new EncounterArea {Location = 017, Slots = new[]{new EncounterSlot {Species = 263, Type = SlotType.Grass }, },},// Zigzagoon @ Route 202
            new EncounterArea {Location = 018, Slots = new[]{new EncounterSlot {Species = 104, Type = SlotType.Grass }, },},// Cubone @ Route 203
            new EncounterArea {Location = 022, Slots = new[]{new EncounterSlot {Species = 231, Type = SlotType.Grass }, },},// Phanpy @ Route 207
            new EncounterArea {Location = 023, Slots = new[]{new EncounterSlot {Species = 206, Type = SlotType.Grass }, },},// Dunsparce @ Route 208
            new EncounterArea {Location = 024, Slots = new[]{new EncounterSlot {Species = 209, Type = SlotType.Grass }, },},// Snubbull @ Route 209
            new EncounterArea {Location = 029, Slots = new[]{new EncounterSlot {Species = 325, Type = SlotType.Grass }, },},// Spoink @ Route 214
            new EncounterArea {Location = 030, Slots = new[]{new EncounterSlot {Species = 096, Type = SlotType.Grass }, },},// Drowzee @ Route 215
            new EncounterArea {Location = 033, Slots = new[]{new EncounterSlot {Species = 100, Type = SlotType.Grass }, },},// Voltorb @ Route 218
            new EncounterArea {Location = 036, Slots = new[]{new EncounterSlot {Species = 083, Type = SlotType.Grass }, },},// Farfetch'd @ Route 221
            new EncounterArea {Location = 037, Slots = new[]{new EncounterSlot {Species = 300, Type = SlotType.Grass }, },},// Skitty @ Route 222
            new EncounterArea {Location = 039, Slots = new[]{new EncounterSlot {Species = 177, Type = SlotType.Grass }, },},// Natu @ Route 224
            new EncounterArea {Location = 040, Slots = new[]{new EncounterSlot {Species = 296, Type = SlotType.Grass }, },},// Makuhita @ Route 225
            new EncounterArea {Location = 041, Slots = new[]{new EncounterSlot {Species = 098, Type = SlotType.Grass }, },},// Krabby @ Route 226
            new EncounterArea {Location = 042, Slots = new[]{new EncounterSlot {Species = 327, Type = SlotType.Grass }, },},// Spinda @ Route 227
            new EncounterArea {Location = 043, Slots = new[]{new EncounterSlot {Species = 374, Type = SlotType.Grass }, },},// Beldum @ Route 228
            new EncounterArea {Location = 045, Slots = new[]{new EncounterSlot {Species = 222, Type = SlotType.Grass }, },},// Corsola @ Route 230
            new EncounterArea {Location = 047, Slots = new[]{new EncounterSlot {Species = 309, Type = SlotType.Grass }, },},// Electrike @ Valley Windworks
            new EncounterArea {Location = 048, Slots = new[]{new EncounterSlot {Species = 287, Type = SlotType.Grass }, },},// Slakoth @ Eterna Forest
        };

        private static readonly EncounterArea[] SlotsDP_Swarm = SlotsDPPT_Swarm.Concat(new[] {
                new EncounterArea {Location = 021, Slots = new[]{new EncounterSlot {Species = 299, Type = SlotType.Grass }, },},// Nosepass @ Route 206
                new EncounterArea {Location = 028, Slots = new[]{new EncounterSlot {Species = 359, Type = SlotType.Grass }, },},// Absol @ Route 213
                new EncounterArea {Location = 031, Slots = new[]{new EncounterSlot {Species = 225, Type = SlotType.Grass }, },},// Delibird @ Route 216
                new EncounterArea {Location = 032, Slots = new[]{new EncounterSlot {Species = 220, Type = SlotType.Grass }, },},// Swinub @ Route 217
                new EncounterArea {Location = 044, Slots = new[]{new EncounterSlot {Species = 016, Type = SlotType.Grass }, },},// Pidgey @ Route 229
                new EncounterArea {Location = 049, Slots = new[]{new EncounterSlot {Species = 081, Type = SlotType.Grass }, },},// Magnemite @ Fuego Ironworks
                new EncounterArea {Location = 076, Slots = new[]{new EncounterSlot {Species = 283, Type = SlotType.Grass }, },},// Surskit @ Lake Verity
                new EncounterArea {Location = 077, Slots = new[]{new EncounterSlot {Species = 108, Type = SlotType.Grass }, },},// Lickitung @ Lake Valor
                new EncounterArea {Location = 078, Slots = new[]{new EncounterSlot {Species = 238, Type = SlotType.Grass }, },},// Smoochum @ Lake Acuity
            }).ToArray();

        private static readonly EncounterArea[] SlotsPt_Swarm = SlotsDPPT_Swarm.Concat(new[] {
                new EncounterArea {Location = 021, Slots = new[]{new EncounterSlot {Species = 246, Type = SlotType.Grass }, },},// Larvitar @ Route 206
                new EncounterArea {Location = 032, Slots = new[]{new EncounterSlot {Species = 225, Type = SlotType.Grass }, },},// Delibird @ Route 217
                new EncounterArea {Location = 044, Slots = new[]{new EncounterSlot {Species = 127, Type = SlotType.Grass }, },},// Pinsir @ Route 229
            }).ToArray();

        private static readonly EncounterArea[] SlotsHGSS_Swarm =
        {
            new EncounterArea {Location = 128, Slots = new[]{new EncounterSlot {Species = 340, Type = SlotType.Old_Rod },
                                                             new EncounterSlot {Species = 340, Type = SlotType.Good_Rod },
                                                             new EncounterSlot {Species = 340, Type = SlotType.Super_Rod },},}, // Whiscash @ Violet City
            new EncounterArea {Location = 143, Slots = new[]{new EncounterSlot {Species = 278, Type = SlotType.Surf },},}, // Wingull @ Vermillion City
            new EncounterArea {Location = 149, Slots = new[]{new EncounterSlot {Species = 261, Type = SlotType.Grass },},}, // Poochyena @ Route 1
            new EncounterArea {Location = 160, Slots = new[]{new EncounterSlot {Species = 369, Type = SlotType.Super_Rod },},}, // Relicanth @ Route 12
            new EncounterArea {Location = 161, Slots = new[]{new EncounterSlot {Species = 113, Type = SlotType.Grass },},}, // Chansey @ Route 13
            new EncounterArea {Location = 167, Slots = new[]{new EncounterSlot {Species = 366, Type = SlotType.Surf },},}, // Clamperl @ Route 19
            new EncounterArea {Location = 173, Slots = new[]{new EncounterSlot {Species = 427, Type = SlotType.Grass },},}, // Buneary @ Route 25
            new EncounterArea {Location = 175, Slots = new[]{new EncounterSlot {Species = 370, Type = SlotType.Surf },},}, // Luvdisc @ Route 27
            new EncounterArea {Location = 180, Slots = new[]{new EncounterSlot {Species = 211, Type = SlotType.Super_Rod },},}, // Qwilfish @ Route 32
            new EncounterArea {Location = 182, Slots = new[]{new EncounterSlot {Species = 280, Type = SlotType.Grass },},}, // Ralts @ Route 34
            new EncounterArea {Location = 183, Slots = new[]{new EncounterSlot {Species = 193, Type = SlotType.Grass },},}, // Yanma @ Route 35
            new EncounterArea {Location = 186, Slots = new[]{new EncounterSlot {Species = 209, Type = SlotType.Grass },},}, // Snubbull @ Route 38
            new EncounterArea {Location = 192, Slots = new[]{new EncounterSlot {Species = 223, Type = SlotType.Good_Rod },
                                                             new EncounterSlot {Species = 223, Type = SlotType.Super_Rod },},}, // Remoraid @ Route 44
            new EncounterArea {Location = 193, Slots = new[]{new EncounterSlot {Species = 333, Type = SlotType.Grass },},}, // Swablu @ Route 45
            new EncounterArea {Location = 195, Slots = new[]{new EncounterSlot {Species = 132, Type = SlotType.Grass },},}, // Ditto @ Route 47
            new EncounterArea {Location = 216, Slots = new[]{new EncounterSlot {Species = 183, Type = SlotType.Grass },},}, // Marill @ Mt. Mortar
            new EncounterArea {Location = 220, Slots = new[]{new EncounterSlot {Species = 206, Type = SlotType.Grass },},}, // Dunsparce @ Dark Cave
            new EncounterArea {Location = 224, Slots = new[]{new EncounterSlot {Species = 401, Type = SlotType.Grass },},}, // Kricketot @ Viridian Forest
        };
        private static readonly EncounterArea[] SlotsHG_Swarm = SlotsHGSS_Swarm.Concat(new[] {
                new EncounterArea {Location = 151, Slots = new[]{new EncounterSlot {Species = 343, Type = SlotType.Grass },},}, // Baltoy @ Route 3
                new EncounterArea {Location = 157, Slots = new[]{new EncounterSlot {Species = 302, Type = SlotType.Grass },},}, // Sableye @ Route 9
        }).ToArray();
        private static readonly EncounterArea[] SlotsSS_Swarm = SlotsHGSS_Swarm.Concat(new[] {
                new EncounterArea {Location = 151, Slots = new[]{new EncounterSlot {Species = 316, Type = SlotType.Grass },},}, // Gulpin @ Route 3
                new EncounterArea {Location = 157, Slots = new[]{new EncounterSlot {Species = 303, Type = SlotType.Grass },},}, // Mawile @ Route 9
        }).ToArray();

        #endregion

        internal static readonly int[] ValidMet_DP =
        {
            001, 002, 003, 004, 005, 006, 007, 008, 009, 010, 011, 012, 013, 014, 015, 016, 017, 018, 019, 020, 
            021, 022, 023, 024, 025, 026, 027, 028, 029, 030, 031, 032, 033, 034, 035, 036, 037, 038, 039, 040, 
            041, 042, 043, 044, 045, 046, 047, 048, 049, 050, 051, 052, 053, 054, 055, 056, 057, 058, 059, 060, 
            061, 062, 063, 064, 065, 066, 067, 068, 069, 070, 071, 072, 073, 074, 075, 076, 077, 078, 079, 080, 
            081, 082, 083, 084, 085,      087, 088, 089, 090, 091, 092, 093, 094, 095, 096, 097, 098, 099, 100, //086: Hall of Origin unreleased event
            101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 
        };
        internal static readonly int[] ValidMet_Pt = ValidMet_DP.Concat(new[]
        {
            112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 
        }).ToArray();
        internal static readonly int[] ValidMet_HGSS =
        {
            126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140,
            141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160,
            161, 162, 263, 164, 165, 166, 167, 168, 169, 170,      172, 173, 174, 175, 176, 177, 178, 179, 180, //171: Route 23 no longer exists
            181, 182, 283, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 100,
            201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220,
            221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232,      234,                               //233: Pokéwalker
        };
    }
}
