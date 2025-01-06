using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glouton.Models
{
  
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class _1
        {
            public Sizes sizes { get; set; }
            public double? uploaded_t { get; set; }
            public string uploader { get; set; }
        }

        public class _100
        {
            public double? h { get; set; }
            public double? w { get; set; }
        }

        public class _2
        {
            public Sizes sizes { get; set; }
            public double? uploaded_t { get; set; }
            public string uploader { get; set; }
        }

        public class _200
        {
            public double? h { get; set; }
            public double? w { get; set; }
        }

        public class _2021
        {
            public double? category_available { get; set; }
            public Data data { get; set; }
            public string grade { get; set; }
            public double? nutrients_available { get; set; }
            public double? nutriscore_applicable { get; set; }
            public double? nutriscore_computed { get; set; }
            public double? score { get; set; }
        }

        public class _2023
        {
            public double? category_available { get; set; }
            public Data data { get; set; }
            public string grade { get; set; }
            public double? nutrients_available { get; set; }
            public double? nutriscore_applicable { get; set; }
            public double? nutriscore_computed { get; set; }
            public double? score { get; set; }
        }

        public class _3
        {
            public Sizes sizes { get; set; }
            public double? uploaded_t { get; set; }
            public string uploader { get; set; }
        }

        public class _4
        {
            public Sizes sizes { get; set; }
            public double? uploaded_t { get; set; }
            public string uploader { get; set; }
        }

        public class _400
        {
            public double? h { get; set; }
            public double? w { get; set; }
        }

        public class _5
        {
            public Sizes sizes { get; set; }
            public double? uploaded_t { get; set; }
            public string uploader { get; set; }
        }

        public class All
        {
        }

        public class CategoriesProperties
        {
        }

        public class CategoryProperties
        {
        }

        public class Components
        {
            public List<Negative> negative { get; set; }
            public List<Positive> positive { get; set; }
        }

        public class Data
        {
            public double? energy { get; set; }
            public double? energy_points { get; set; }
            public double? energy_value { get; set; }
            public double? fiber { get; set; }
            public double? fiber_points { get; set; }
            public double? fiber_value { get; set; }
            public double? fruits_vegetables_nuts_colza_walnut_olive_oils { get; set; }
            public double? fruits_vegetables_nuts_colza_walnut_olive_oils_points { get; set; }
            public double? fruits_vegetables_nuts_colza_walnut_olive_oils_value { get; set; }
            public double? is_beverage { get; set; }
            public double? is_cheese { get; set; }
            public double? is_fat { get; set; }
            public double? is_water { get; set; }
            public double? negative_points { get; set; }
            public double? positive_points { get; set; }
            public double? proteins { get; set; }
            public double? proteins_points { get; set; }
            public double? proteins_value { get; set; }
            public double? saturated_fat { get; set; }
            public double? saturated_fat_points { get; set; }
            public double? saturated_fat_value { get; set; }
            public double? sodium { get; set; }
            public double? sodium_points { get; set; }
            public double? sodium_value { get; set; }
            public double? sugars { get; set; }
            public double? sugars_points { get; set; }
            public double? sugars_value { get; set; }
            public Components components { get; set; }
            public double? count_proteins { get; set; }
            public string count_proteins_reason { get; set; }
            public double? is_fat_oil_nuts_seeds { get; set; }
            public double? is_red_meat_product { get; set; }
            public double? negative_points_max { get; set; }
            public List<string> positive_nutrients { get; set; }
            public double? positive_points_max { get; set; }
        }

        public class Display
        {
            public string en { get; set; }
        }

        public class EnUnknown
        {
        }

        public class Front
        {
            public string geometry { get; set; }
            public string imgid { get; set; }
            public object normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
            public Display display { get; set; }
            public Small small { get; set; }
            public Thumb thumb { get; set; }
        }

        public class FrontEn
        {
            public string geometry { get; set; }
            public string imgid { get; set; }
            public object normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
        }

        public class Full
        {
            public double? h { get; set; }
            public double? w { get; set; }
        }

        public class Images
        {
            [JsonProperty("1")]
            public _1 _1 { get; set; }

            [JsonProperty("2")]
            public _2 _2 { get; set; }

            [JsonProperty("3")]
            public _3 _3 { get; set; }

            [JsonProperty("4")]
            public _4 _4 { get; set; }

            [JsonProperty("5")]
            public _5 _5 { get; set; }
            public Front front { get; set; }
            public FrontEn front_en { get; set; }
            public IngredientsEn ingredients_en { get; set; }
            public Nutrition nutrition { get; set; }
            public NutritionEn nutrition_en { get; set; }
        }

        public class Ingredient
        {
            public string id { get; set; }
            public List<Ingredient> ingredients { get; set; }
            public double? is_in_taxonomy { get; set; }
            public double? percent_estimate { get; set; }
            public double percent_max { get; set; }
            public double? percent_min { get; set; }
            public string text { get; set; }
            public string vegan { get; set; }
            public string vegetarian { get; set; }
            public string ciqual_proxy_food_code { get; set; }
            public string ciqual_food_code { get; set; }
            public string ecobalyse_code { get; set; }
            public string from_palm_oil { get; set; }
            public string geometry { get; set; }
            public string imgid { get; set; }
            public string normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
            public Display display { get; set; }
            public Small small { get; set; }
            public Thumb thumb { get; set; }
        }

        public class IngredientsAnalysis
        {
            [JsonProperty("en:palm-oil-content-unknown")]
            public List<string> enpalmoilcontentunknown { get; set; }

            [JsonProperty("en:vegan-status-unknown")]
            public List<string> enveganstatusunknown { get; set; }

            [JsonProperty("en:vegetarian-status-unknown")]
            public List<string> envegetarianstatusunknown { get; set; }
        }

        public class IngredientsEn
        {
            public string geometry { get; set; }
            public string imgid { get; set; }
            public string normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
        }

        public class Languages
        {
            [JsonProperty("en:english")]
            public double? enenglish { get; set; }
        }

        public class LanguagesCodes
        {
            public double? en { get; set; }
        }

        public class Negative
        {
            public string id { get; set; }
            public double? points { get; set; }
            public double? points_max { get; set; }
            public string unit { get; set; }
            public double? value { get; set; }
        }

        public class NovaGroupsMarkers
        {
            [JsonProperty("3")]
            public List<List<string>> _3 { get; set; }

            [JsonProperty("4")]
            public List<List<string>> _4 { get; set; }
        }

        public class NutrientLevels
        {
            public string fat { get; set; }
            public string salt { get; set; }

            [JsonProperty("saturated-fat")]
            public string saturatedfat { get; set; }
            public string sugars { get; set; }
        }

        public class Nutriments
        {
            public double? calcium { get; set; }
            public double? calcium_100g { get; set; }
            public double? calcium_serving { get; set; }
            public string calcium_unit { get; set; }
            public double? calcium_value { get; set; }
            public double? carbohydrates { get; set; }
            public double? carbohydrates_100g { get; set; }
            public double? carbohydrates_serving { get; set; }
            public string carbohydrates_unit { get; set; }
            public double? carbohydrates_value { get; set; }
            public double? cholesterol { get; set; }
            public double? cholesterol_100g { get; set; }
            public double? cholesterol_serving { get; set; }
            public string cholesterol_unit { get; set; }
            public double? cholesterol_value { get; set; }
            public double? energy { get; set; }

            [JsonProperty("energy-kcal")]
            public double? energykcal { get; set; }

            [JsonProperty("energy-kcal_100g")]
            public double? energykcal_100g { get; set; }

            [JsonProperty("energy-kcal_serving")]
            public double? energykcal_serving { get; set; }

            [JsonProperty("energy-kcal_unit")]
            public string energykcal_unit { get; set; }

            [JsonProperty("energy-kcal_value")]
            public double? energykcal_value { get; set; }

            [JsonProperty("energy-kcal_value_computed")]
            public double? energykcal_value_computed { get; set; }
            public double? energy_100g { get; set; }
            public double? energy_serving { get; set; }
            public string energy_unit { get; set; }
            public double? energy_value { get; set; }
            public double? fat { get; set; }
            public double? fat_100g { get; set; }
            public double? fat_serving { get; set; }
            public string fat_unit { get; set; }
            public double? fat_value { get; set; }
            public double? fiber { get; set; }
            public double? fiber_100g { get; set; }
            public double? fiber_serving { get; set; }
            public string fiber_unit { get; set; }
            public double? fiber_value { get; set; }

            [JsonProperty("fruits-vegetables-legumes-estimate-from-ingredients_100g")]
            public double? fruitsvegetableslegumesestimatefromingredients_100g { get; set; }

            [JsonProperty("fruits-vegetables-legumes-estimate-from-ingredients_serving")]
            public double? fruitsvegetableslegumesestimatefromingredients_serving { get; set; }

            [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_100g")]
            public double? fruitsvegetablesnutsestimatefromingredients_100g { get; set; }

            [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_serving")]
            public double? fruitsvegetablesnutsestimatefromingredients_serving { get; set; }
            public double? iron { get; set; }
            public double? iron_100g { get; set; }
            public double? iron_serving { get; set; }
            public string iron_unit { get; set; }
            public double? iron_value { get; set; }

            [JsonProperty("nova-group")]
            public double? novagroup { get; set; }

            [JsonProperty("nova-group_100g")]
            public double? novagroup_100g { get; set; }

            [JsonProperty("nova-group_serving")]
            public double? novagroup_serving { get; set; }

            [JsonProperty("nutrition-score-fr")]
            public double? nutritionscorefr { get; set; }

            [JsonProperty("nutrition-score-fr_100g")]
            public double? nutritionscorefr_100g { get; set; }
            public double? proteins { get; set; }
            public double? proteins_100g { get; set; }
            public double? proteins_serving { get; set; }
            public string proteins_unit { get; set; }
            public double? proteins_value { get; set; }
            public double? salt { get; set; }
            public double? salt_100g { get; set; }
            public double? salt_serving { get; set; }
            public string salt_unit { get; set; }
            public double? salt_value { get; set; }

            [JsonProperty("saturated-fat")]
            public double? saturatedfat { get; set; }

            [JsonProperty("saturated-fat_100g")]
            public double? saturatedfat_100g { get; set; }

            [JsonProperty("saturated-fat_serving")]
            public double? saturatedfat_serving { get; set; }

            [JsonProperty("saturated-fat_unit")]
            public string saturatedfat_unit { get; set; }

            [JsonProperty("saturated-fat_value")]
            public double? saturatedfat_value { get; set; }
            public double? sodium { get; set; }
            public double? sodium_100g { get; set; }
            public double? sodium_serving { get; set; }
            public string sodium_unit { get; set; }
            public double? sodium_value { get; set; }
            public double? sugars { get; set; }
            public double? sugars_100g { get; set; }
            public double? sugars_serving { get; set; }
            public string sugars_unit { get; set; }
            public double? sugars_value { get; set; }

            [JsonProperty("trans-fat")]
            public double? transfat { get; set; }

            [JsonProperty("trans-fat_100g")]
            public double? transfat_100g { get; set; }

            [JsonProperty("trans-fat_serving")]
            public double? transfat_serving { get; set; }

            [JsonProperty("trans-fat_unit")]
            public string transfat_unit { get; set; }

            [JsonProperty("trans-fat_value")]
            public double? transfat_value { get; set; }

            [JsonProperty("vitamin-a")]
            public double? vitamina { get; set; }

            [JsonProperty("vitamin-a_100g")]
            public double? vitamina_100g { get; set; }

            [JsonProperty("vitamin-a_serving")]
            public double? vitamina_serving { get; set; }

            [JsonProperty("vitamin-a_unit")]
            public string vitamina_unit { get; set; }

            [JsonProperty("vitamin-a_value")]
            public double? vitamina_value { get; set; }

            [JsonProperty("vitamin-c")]
            public double? vitaminc { get; set; }

            [JsonProperty("vitamin-c_100g")]
            public double? vitaminc_100g { get; set; }

            [JsonProperty("vitamin-c_serving")]
            public double? vitaminc_serving { get; set; }

            [JsonProperty("vitamin-c_unit")]
            public string vitaminc_unit { get; set; }

            [JsonProperty("vitamin-c_value")]
            public double? vitaminc_value { get; set; }
        }

        public class Nutriscore
        {
            [JsonProperty("2021")]
            public _2021 _2021 { get; set; }

            [JsonProperty("2023")]
            public _2023 _2023 { get; set; }
        }

        public class NutriscoreData
        {
            public Components components { get; set; }
            public double? count_proteins { get; set; }
            public string count_proteins_reason { get; set; }
            public string grade { get; set; }
            public double? is_beverage { get; set; }
            public double? is_cheese { get; set; }
            public double? is_fat_oil_nuts_seeds { get; set; }
            public double? is_red_meat_product { get; set; }
            public double? is_water { get; set; }
            public double? negative_points { get; set; }
            public double? negative_points_max { get; set; }
            public List<string> positive_nutrients { get; set; }
            public double? positive_points { get; set; }
            public double? positive_points_max { get; set; }
            public double? score { get; set; }
        }

        public class Nutrition
        {
            public string geometry { get; set; }
            public string imgid { get; set; }
            public string normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
            public Display display { get; set; }
            public Small small { get; set; }
            public Thumb thumb { get; set; }
        }

        public class NutritionEn
        {
            public string geometry { get; set; }
            public string imgid { get; set; }
            public string normalize { get; set; }
            public string rev { get; set; }
            public Sizes sizes { get; set; }
            public object white_magic { get; set; }
        }

        public class OrgDatabaseUsda
        {
            public DateTime available_date { get; set; }
            public string fdc_category { get; set; }
            public string fdc_data_source { get; set; }
            public string fdc_id { get; set; }
            public DateTime modified_date { get; set; }
            public DateTime publication_date { get; set; }
        }

        public class Packaging
        {
            public string shape { get; set; }
        }

        public class PackagingsMaterials
        {
            public All all { get; set; }

            [JsonProperty("en:unknown")]
            public EnUnknown enunknown { get; set; }
        }

        public class Positive
        {
            public string id { get; set; }
            public double? points { get; set; }
            public double? points_max { get; set; }
            public string unit { get; set; }
            public double? value { get; set; }
        }

        public class Product
        {
            public string _id { get; set; }
            public List<string> _keywords { get; set; }
            public List<object> added_countries_tags { get; set; }
            public double? additives_n { get; set; }
            public List<string> additives_original_tags { get; set; }
            public List<string> additives_tags { get; set; }
            public string allergens { get; set; }
            public string allergens_from_ingredients { get; set; }
            public string allergens_from_user { get; set; }
            public List<string> allergens_hierarchy { get; set; }
            public string allergens_lc { get; set; }
            public List<string> allergens_tags { get; set; }
            public List<object> amino_acids_prev_tags { get; set; }
            public List<object> amino_acids_tags { get; set; }
            public string brand_owner { get; set; }
            public string brand_owner_imported { get; set; }
            public string brands { get; set; }
            public List<string> brands_tags { get; set; }
            public string categories { get; set; }
            public List<string> categories_hierarchy { get; set; }
            public string categories_imported { get; set; }
            public string categories_lc { get; set; }
            public string categories_old { get; set; }
            public CategoriesProperties categories_properties { get; set; }
            public List<string> categories_properties_tags { get; set; }
            public List<string> categories_tags { get; set; }
            public CategoryProperties category_properties { get; set; }
            public List<object> checkers { get; set; }
            public List<object> checkers_tags { get; set; }
            public List<string> ciqual_food_name_tags { get; set; }
            public List<object> cities_tags { get; set; }
            public string code { get; set; }
            public List<string> codes_tags { get; set; }
            public string compared_to_category { get; set; }
            public double? complete { get; set; }
            public double? completeness { get; set; }
            public List<string> correctors { get; set; }
            public List<string> correctors_tags { get; set; }
            public string countries { get; set; }
            public List<string> countries_hierarchy { get; set; }
            public string countries_imported { get; set; }
            public string countries_lc { get; set; }
            public List<string> countries_tags { get; set; }
            public double? created_t { get; set; }
            public string creator { get; set; }
            public List<object> data_quality_bugs_tags { get; set; }
            public List<object> data_quality_errors_tags { get; set; }
            public List<string> data_quality_info_tags { get; set; }
            public List<string> data_quality_tags { get; set; }
            public List<string> data_quality_warnings_tags { get; set; }
            public string data_sources { get; set; }
            public string data_sources_imported { get; set; }
            public List<string> data_sources_tags { get; set; }
            public List<string> debug_param_sorted_langs { get; set; }
            public List<string> editors { get; set; }
            public List<string> editors_tags { get; set; }
            public string emb_codes { get; set; }
            public string emb_codes_20141016 { get; set; }
            public string emb_codes_orig { get; set; }
            public List<object> emb_codes_tags { get; set; }
            public List<string> entry_dates_tags { get; set; }
            public string expiration_date { get; set; }
            public string food_groups { get; set; }
            public List<string> food_groups_tags { get; set; }

            [JsonProperty("fruits-vegetables-nuts_100g_estimate")]
            public double? fruitsvegetablesnuts_100g_estimate { get; set; }
            public string generic_name { get; set; }
            public string generic_name_en { get; set; }
            public string id { get; set; }
            public string image_front_small_url { get; set; }
            public string image_front_thumb_url { get; set; }
            public string image_front_url { get; set; }
            public string image_ingredients_small_url { get; set; }
            public string image_ingredients_thumb_url { get; set; }
            public string image_ingredients_url { get; set; }
            public string image_nutrition_small_url { get; set; }
            public string image_nutrition_thumb_url { get; set; }
            public string image_nutrition_url { get; set; }
            public string image_small_url { get; set; }
            public string image_thumb_url { get; set; }
            public string image_url { get; set; }
            public Images images { get; set; }
            public List<string> informers { get; set; }
            public List<string> informers_tags { get; set; }
            public List<Ingredient> ingredients { get; set; }
            public IngredientsAnalysis ingredients_analysis { get; set; }
            public List<string> ingredients_analysis_tags { get; set; }
            public List<string> ingredients_debug { get; set; }
            public double? ingredients_from_or_that_may_be_from_palm_oil_n { get; set; }
            public double? ingredients_from_palm_oil_n { get; set; }
            public List<object> ingredients_from_palm_oil_tags { get; set; }
            public List<string> ingredients_hierarchy { get; set; }
            public List<string> ingredients_ids_debug { get; set; }
            public string ingredients_lc { get; set; }
            public double? ingredients_n { get; set; }
            public List<string> ingredients_n_tags { get; set; }
            public double? ingredients_non_nutritive_sweeteners_n { get; set; }
            public List<string> ingredients_original_tags { get; set; }
            public double? ingredients_percent_analysis { get; set; }
            public double? ingredients_sweeteners_n { get; set; }
            public List<string> ingredients_tags { get; set; }
            public string ingredients_text { get; set; }
            public string ingredients_text_debug { get; set; }
            public string ingredients_text_en { get; set; }
            public string ingredients_text_en_imported { get; set; }
            public string ingredients_text_with_allergens { get; set; }
            public string ingredients_text_with_allergens_en { get; set; }
            public double? ingredients_that_may_be_from_palm_oil_n { get; set; }
            public List<object> ingredients_that_may_be_from_palm_oil_tags { get; set; }
            public double? ingredients_with_specified_percent_n { get; set; }
            public double? ingredients_with_specified_percent_sum { get; set; }
            public double? ingredients_with_unspecified_percent_n { get; set; }
            public double? ingredients_with_unspecified_percent_sum { get; set; }
            public List<string> ingredients_without_ciqual_codes { get; set; }
            public double? ingredients_without_ciqual_codes_n { get; set; }
            public List<string> ingredients_without_ecobalyse_ids { get; set; }
            public double? ingredients_without_ecobalyse_ids_n { get; set; }
            public string interface_version_created { get; set; }
            public string interface_version_modified { get; set; }
            public double? known_ingredients_n { get; set; }
            public string labels { get; set; }
            public List<string> labels_hierarchy { get; set; }
            public string labels_lc { get; set; }
            public string labels_old { get; set; }
            public List<string> labels_tags { get; set; }
            public string lang { get; set; }
            public Languages languages { get; set; }
            public LanguagesCodes languages_codes { get; set; }
            public List<string> languages_hierarchy { get; set; }
            public List<string> languages_tags { get; set; }
            public List<string> last_edit_dates_tags { get; set; }
            public string last_editor { get; set; }
            public List<string> last_image_dates_tags { get; set; }
            public double? last_image_t { get; set; }
            public string last_modified_by { get; set; }
            public double? last_modified_t { get; set; }
            public double? last_updated_t { get; set; }
            public string lc { get; set; }
            public string lc_imported { get; set; }
            public string link { get; set; }
            public List<object> main_countries_tags { get; set; }
            public string manufacturing_places { get; set; }
            public List<object> manufacturing_places_tags { get; set; }
            public string max_imgid { get; set; }
            public List<object> minerals_prev_tags { get; set; }
            public List<object> minerals_tags { get; set; }
            public List<string> misc_tags { get; set; }
            public string no_nutrition_data { get; set; }
            public double? nova_group { get; set; }
            public string nova_group_debug { get; set; }
            public string nova_groups { get; set; }
            public NovaGroupsMarkers nova_groups_markers { get; set; }
            public List<string> nova_groups_tags { get; set; }
            public List<object> nucleotides_prev_tags { get; set; }
            public List<object> nucleotides_tags { get; set; }
            public NutrientLevels nutrient_levels { get; set; }
            public List<string> nutrient_levels_tags { get; set; }
            public Nutriments nutriments { get; set; }
            public Nutriscore nutriscore { get; set; }
            public List<string> nutriscore_2021_tags { get; set; }
            public List<string> nutriscore_2023_tags { get; set; }
            public NutriscoreData nutriscore_data { get; set; }
            public string nutriscore_grade { get; set; }
            public double? nutriscore_score { get; set; }
            public double? nutriscore_score_opposite { get; set; }
            public List<string> nutriscore_tags { get; set; }
            public string nutriscore_version { get; set; }
            public string nutrition_data { get; set; }
            public string nutrition_data_per { get; set; }
            public string nutrition_data_per_imported { get; set; }
            public string nutrition_data_prepared { get; set; }
            public string nutrition_data_prepared_per { get; set; }
            public string nutrition_data_prepared_per_imported { get; set; }
            public string nutrition_grade_fr { get; set; }
            public string nutrition_grades { get; set; }
            public List<string> nutrition_grades_tags { get; set; }
            public double? nutrition_score_beverage { get; set; }
            public string nutrition_score_debug { get; set; }
            public double? nutrition_score_warning_fruits_vegetables_legumes_estimate_from_ingredients { get; set; }
            public double? nutrition_score_warning_fruits_vegetables_legumes_estimate_from_ingredients_value { get; set; }
            public double? nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients { get; set; }
            public double? nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients_value { get; set; }
            public string obsolete { get; set; }
            public string obsolete_since_date { get; set; }
            public string origin { get; set; }
            public string origin_en { get; set; }
            public string origins { get; set; }
            public List<string> origins_hierarchy { get; set; }
            public string origins_lc { get; set; }
            public string origins_old { get; set; }
            public List<string> origins_tags { get; set; }
            public List<object> other_nutritional_substances_tags { get; set; }
            public string packaging { get; set; }
            public List<string> packaging_hierarchy { get; set; }
            public string packaging_lc { get; set; }
            public List<object> packaging_materials_tags { get; set; }
            public string packaging_old { get; set; }
            public string packaging_old_before_taxonomization { get; set; }
            public List<object> packaging_recycling_tags { get; set; }
            public List<string> packaging_shapes_tags { get; set; }
            public List<string> packaging_tags { get; set; }
            public string packaging_text { get; set; }
            public string packaging_text_en { get; set; }
            public List<Packaging> packagings { get; set; }
            public double? packagings_complete { get; set; }
            public PackagingsMaterials packagings_materials { get; set; }
            public double? packagings_n { get; set; }
            public List<string> photographers { get; set; }
            public List<string> photographers_tags { get; set; }
            public string pnns_groups_1 { get; set; }
            public List<string> pnns_groups_1_tags { get; set; }
            public string pnns_groups_2 { get; set; }
            public List<string> pnns_groups_2_tags { get; set; }
            public long popularity_key { get; set; }
            public List<string> popularity_tags { get; set; }
            public string product_name { get; set; }
            public string product_name_en { get; set; }
            public string product_name_en_imported { get; set; }
            public string product_quantity { get; set; }
            public string product_quantity_unit { get; set; }
            public string product_type { get; set; }
            public string purchase_places { get; set; }
            public List<object> purchase_places_tags { get; set; }
            public string quantity { get; set; }
            public List<object> removed_countries_tags { get; set; }
            public double? rev { get; set; }
            public double? scans_n { get; set; }
            public SelectedImages selected_images { get; set; }
            public string serving_quantity { get; set; }
            public string serving_quantity_unit { get; set; }
            public string serving_size { get; set; }
            public string serving_size_imported { get; set; }
            public double? sortkey { get; set; }
            public List<Source> sources { get; set; }
            public SourcesFields sources_fields { get; set; }
            public string states { get; set; }
            public List<string> states_hierarchy { get; set; }
            public List<string> states_tags { get; set; }
            public string stores { get; set; }
            public List<object> stores_tags { get; set; }
            public string teams { get; set; }
            public List<string> teams_tags { get; set; }
            public string traces { get; set; }
            public string traces_from_ingredients { get; set; }
            public string traces_from_user { get; set; }
            public List<string> traces_hierarchy { get; set; }
            public string traces_lc { get; set; }
            public List<string> traces_tags { get; set; }
            public double? unique_scans_n { get; set; }
            public double? unknown_ingredients_n { get; set; }
            public List<object> unknown_nutrients_tags { get; set; }
            public string update_key { get; set; }
            public List<object> vitamins_prev_tags { get; set; }
            public List<object> vitamins_tags { get; set; }
            public List<object> weighers_tags { get; set; }
        }

        public class Root
        {
            public string code { get; set; }
            public Product product { get; set; }
            public double? status { get; set; }
            public string status_verbose { get; set; }
        }

        public class SelectedImages
        {
            public Front front { get; set; }
            public Nutrition nutrition { get; set; }
        }

        public class Sizes
        {
            [JsonProperty("100")]
            public _100 _100 { get; set; }

            [JsonProperty("400")]
            public _400 _400 { get; set; }
            public Full full { get; set; }

            [JsonProperty("200")]
            public _200 _200 { get; set; }
        }

        public class Small
        {
            public string en { get; set; }
        }

        public class Source
        {
            public List<string> fields { get; set; }
            public string id { get; set; }
            public List<object> images { get; set; }
            public double? import_t { get; set; }
            public string url { get; set; }
            public object manufacturer { get; set; }
            public string name { get; set; }
        }

        public class SourcesFields
        {
            [JsonProperty("org-database-usda")]
            public OrgDatabaseUsda orgdatabaseusda { get; set; }
        }

        public class Thumb
        {
            public string en { get; set; }
        }


    
}
