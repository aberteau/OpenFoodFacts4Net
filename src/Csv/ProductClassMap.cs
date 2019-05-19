﻿using CsvHelper.Configuration;
using OpenFoodFacts4Net.Csv.Data;

namespace OpenFoodFacts4Net.Csv
{
    public sealed class ProductClassMap
        : ClassMap<Product>
    {
        public ProductClassMap()
        {
            Map(m => m.Code).Index(0);
            Map(m => m.Url).Index(1);
            Map(m => m.Creator).Index(2);
            Map(m => m.CreatedTimestamp).Index(3);
            Map(m => m.Created).Index(4);
            Map(m => m.LastModifiedTimestamp).Index(5);
            Map(m => m.LastModified).Index(6);
            Map(m => m.ProductName).Index(7);
            Map(m => m.GenericName).Index(8);
            Map(m => m.Quantity).Index(9);
            Map(m => m.Packaging).Index(10);
            Map(m => m.PackagingTags).Index(11);
            Map(m => m.Brands).Index(12);
            Map(m => m.BrandsTags).Index(13);
            Map(m => m.Categories).Index(14);
            Map(m => m.CategoriesTags).Index(15);
            Map(m => m.CategoriesFr).Index(16);
            Map(m => m.Origins).Index(17);
            Map(m => m.OriginsTags).Index(18);
            Map(m => m.ManufacturingPlaces).Index(19);
            Map(m => m.ManufacturingPlacesTags).Index(20);
            Map(m => m.Labels).Index(21);
            Map(m => m.LabelsTags).Index(22);
            Map(m => m.LabelsFr).Index(23);
            Map(m => m.EmbCodes).Index(24);
            Map(m => m.EmbCodesTags).Index(25);
            Map(m => m.FirstPackagingCodeGeo).Index(26);
            Map(m => m.Cities).Index(27);
            Map(m => m.CitiesTags).Index(28);
            Map(m => m.PurchasePlaces).Index(29);
            Map(m => m.Stores).Index(30);
            Map(m => m.Countries).Index(31);
            Map(m => m.CountriesTags).Index(32);
            Map(m => m.CountriesFr).Index(33);
            Map(m => m.IngredientsText).Index(34);
            Map(m => m.Allergens).Index(35);
            Map(m => m.AllergensFr).Index(36);
            Map(m => m.Traces).Index(37);
            Map(m => m.TracesTags).Index(38);
            Map(m => m.TracesFr).Index(39);
            Map(m => m.ServingSize).Index(40);
            Map(m => m.ServingQuantity).Index(41);
            Map(m => m.NoNutriments).Index(42);
            Map(m => m.AdditivesN).Index(43);
            Map(m => m.Additives).Index(44);
            Map(m => m.AdditivesTags).Index(45);
            Map(m => m.AdditivesFr).Index(46);
            Map(m => m.IngredientsFromPalmOilN).Index(47);
            Map(m => m.IngredientsFromPalmOil).Index(48);
            Map(m => m.IngredientsFromPalmOilTags).Index(49);
            Map(m => m.IngredientsThatMayBeFromPalmOilN).Index(50);
            Map(m => m.IngredientsThatMayBeFromPalmOil).Index(51);
            Map(m => m.IngredientsThatMayBeFromPalmOilTags).Index(52);
            Map(m => m.NutritionGradeFr).Index(53);
            Map(m => m.NovaGroup).Index(54);
            Map(m => m.PnnsGroups1).Index(55);
            Map(m => m.PnnsGroups2).Index(56);
            Map(m => m.States).Index(57);
            Map(m => m.StatesTags).Index(58);
            Map(m => m.StatesFr).Index(59);
            Map(m => m.MainCategory).Index(60);
            Map(m => m.MainCategoryFr).Index(61);
            Map(m => m.ImageUrl).Index(62);
            Map(m => m.ImageSmallUrl).Index(63);
            Map(m => m.ImageIngredientsUrl).Index(64);
            Map(m => m.ImageIngredientsSmallUrl).Index(65);
            Map(m => m.ImageNutritionUrl).Index(66);
            Map(m => m.ImageNutritionSmallUrl).Index(67);
            Map(m => m.Energy_100G).Index(68);
            Map(m => m.EnergyFromFat_100G).Index(69);
            Map(m => m.Fat_100G).Index(70);
            Map(m => m.SaturatedFat_100G).Index(71);
            Map(m => m.ButyricAcid_100G).Index(72);
            Map(m => m.CaproicAcid_100G).Index(73);
            Map(m => m.CaprylicAcid_100G).Index(74);
            Map(m => m.CapricAcid_100G).Index(75);
            Map(m => m.LauricAcid_100G).Index(76);
            Map(m => m.MyristicAcid_100G).Index(77);
            Map(m => m.PalmiticAcid_100G).Index(78);
            Map(m => m.StearicAcid_100G).Index(79);
            Map(m => m.ArachidicAcid_100G).Index(80);
            Map(m => m.BehenicAcid_100G).Index(81);
            Map(m => m.LignocericAcid_100G).Index(82);
            Map(m => m.CeroticAcid_100G).Index(83);
            Map(m => m.MontanicAcid_100G).Index(84);
            Map(m => m.MelissicAcid_100G).Index(85);
            Map(m => m.MonounsaturatedFat_100G).Index(86);
            Map(m => m.PolyunsaturatedFat_100G).Index(87);
            Map(m => m.Omega3Fat_100G).Index(88);
            Map(m => m.AlphaLinolenicAcid_100G).Index(89);
            Map(m => m.EicosapentaenoicAcid_100G).Index(90);
            Map(m => m.DocosahexaenoicAcid_100G).Index(91);
            Map(m => m.Omega6Fat_100G).Index(92);
            Map(m => m.LinoleicAcid_100G).Index(93);
            Map(m => m.ArachidonicAcid_100G).Index(94);
            Map(m => m.GammaLinolenicAcid_100G).Index(95);
            Map(m => m.DihomoGammaLinolenicAcid_100G).Index(96);
            Map(m => m.Omega9Fat_100G).Index(97);
            Map(m => m.OleicAcid_100G).Index(98);
            Map(m => m.ElaidicAcid_100G).Index(99);
            Map(m => m.GondoicAcid_100G).Index(100);
            Map(m => m.MeadAcid_100G).Index(101);
            Map(m => m.ErucicAcid_100G).Index(102);
            Map(m => m.NervonicAcid_100G).Index(103);
            Map(m => m.TransFat_100G).Index(104);
            Map(m => m.Cholesterol_100G).Index(105);
            Map(m => m.Carbohydrates_100G).Index(106);
            Map(m => m.Sugars_100G).Index(107);
            Map(m => m.Sucrose_100G).Index(108);
            Map(m => m.Glucose_100G).Index(109);
            Map(m => m.Fructose_100G).Index(110);
            Map(m => m.Lactose_100G).Index(111);
            Map(m => m.Maltose_100G).Index(112);
            Map(m => m.Maltodextrins_100G).Index(113);
            Map(m => m.Starch_100G).Index(114);
            Map(m => m.Polyols_100G).Index(115);
            Map(m => m.Fiber_100G).Index(116);
            Map(m => m.Proteins_100G).Index(117);
            Map(m => m.Casein_100G).Index(118);
            Map(m => m.SerumProteins_100G).Index(119);
            Map(m => m.Nucleotides_100G).Index(120);
            Map(m => m.Salt_100G).Index(121);
            Map(m => m.Sodium_100G).Index(122);
            Map(m => m.Alcohol_100G).Index(123);
            Map(m => m.VitaminA_100G).Index(124);
            Map(m => m.BetaCarotene_100G).Index(125);
            Map(m => m.VitaminD_100G).Index(126);
            Map(m => m.VitaminE_100G).Index(127);
            Map(m => m.VitaminK_100G).Index(128);
            Map(m => m.VitaminC_100G).Index(129);
            Map(m => m.VitaminB1_100G).Index(130);
            Map(m => m.VitaminB2_100G).Index(131);
            Map(m => m.VitaminPp_100G).Index(132);
            Map(m => m.VitaminB6_100G).Index(133);
            Map(m => m.VitaminB9_100G).Index(134);
            Map(m => m.Folates_100G).Index(135);
            Map(m => m.VitaminB12_100G).Index(136);
            Map(m => m.Biotin_100G).Index(137);
            Map(m => m.PantothenicAcid_100G).Index(138);
            Map(m => m.Silica_100G).Index(139);
            Map(m => m.Bicarbonate_100G).Index(140);
            Map(m => m.Potassium_100G).Index(141);
            Map(m => m.Chloride_100G).Index(142);
            Map(m => m.Calcium_100G).Index(143);
            Map(m => m.Phosphorus_100G).Index(144);
            Map(m => m.Iron_100G).Index(145);
            Map(m => m.Magnesium_100G).Index(146);
            Map(m => m.Zinc_100G).Index(147);
            Map(m => m.Copper_100G).Index(148);
            Map(m => m.Manganese_100G).Index(149);
            Map(m => m.Fluoride_100G).Index(150);
            Map(m => m.Selenium_100G).Index(151);
            Map(m => m.Chromium_100G).Index(152);
            Map(m => m.Molybdenum_100G).Index(153);
            Map(m => m.Iodine_100G).Index(154);
            Map(m => m.Caffeine_100G).Index(155);
            Map(m => m.Taurine_100G).Index(156);
            Map(m => m.Ph_100G).Index(157);
            Map(m => m.FruitsVegetablesNuts_100G).Index(158);
            Map(m => m.FruitsVegetablesNutsDried_100G).Index(159);
            Map(m => m.FruitsVegetablesNutsEstimate_100G).Index(160);
            Map(m => m.CollagenMeatProteinRatio_100G).Index(161);
            Map(m => m.Cocoa_100G).Index(162);
            Map(m => m.Chlorophyl_100G).Index(163);
            Map(m => m.CarbonFootprint_100G).Index(164);
            Map(m => m.CarbonFootprintFromMeatOrFish_100G).Index(165);
            Map(m => m.NutritionScoreFr_100G).Index(166);
            Map(m => m.NutritionScoreUk_100G).Index(167);
            Map(m => m.GlycemicIndex_100G).Index(168);
            Map(m => m.WaterHardness_100G).Index(169);
            Map(m => m.Choline_100G).Index(170);
            Map(m => m.Phylloquinone_100G).Index(171);
            Map(m => m.BetaGlucan_100G).Index(172);
            Map(m => m.Inositol_100G).Index(173);
            Map(m => m.Carnitine_100G).Index(174);
        }
    }
}
