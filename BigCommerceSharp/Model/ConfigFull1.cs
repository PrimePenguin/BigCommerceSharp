using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The values for option config can vary based on the Modifier created.
  /// </summary>
  [DataContract]
  public class ConfigFull1 {
    /// <summary>
    /// (date, text, multi_line_text, numbers_only_text) The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string. 
    /// </summary>
    /// <value>(date, text, multi_line_text, numbers_only_text) The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string. </value>
    [DataMember(Name="default_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_value")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// (checkbox) Flag for setting the checkbox to be checked by default. 
    /// </summary>
    /// <value>(checkbox) Flag for setting the checkbox to be checked by default. </value>
    [DataMember(Name="checked_by_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checked_by_default")]
    public bool? CheckedByDefault { get; set; }

    /// <summary>
    /// (checkbox) Label displayed for the checkbox option. 
    /// </summary>
    /// <value>(checkbox) Label displayed for the checkbox option. </value>
    [DataMember(Name="checkbox_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkbox_label")]
    public string CheckboxLabel { get; set; }

    /// <summary>
    /// (date) Flag to limit the dates allowed to be entered on a date option. 
    /// </summary>
    /// <value>(date) Flag to limit the dates allowed to be entered on a date option. </value>
    [DataMember(Name="date_limited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_limited")]
    public bool? DateLimited { get; set; }

    /// <summary>
    /// (date) The type of limit that is allowed to be entered on a date option. 
    /// </summary>
    /// <value>(date) The type of limit that is allowed to be entered on a date option. </value>
    [DataMember(Name="date_limit_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_limit_mode")]
    public string DateLimitMode { get; set; }

    /// <summary>
    /// (date) The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string. 
    /// </summary>
    /// <value>(date) The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string. </value>
    [DataMember(Name="date_earliest_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_earliest_value")]
    public DateTime? DateEarliestValue { get; set; }

    /// <summary>
    /// (date) The latest date allowed to be entered on the date option, as an ISO-8601 formatted string. 
    /// </summary>
    /// <value>(date) The latest date allowed to be entered on the date option, as an ISO-8601 formatted string. </value>
    [DataMember(Name="date_latest_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_latest_value")]
    public DateTime? DateLatestValue { get; set; }

    /// <summary>
    /// (file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: `specific` - restricts uploads to particular file types; `all` - allows all file types. 
    /// </summary>
    /// <value>(file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: `specific` - restricts uploads to particular file types; `all` - allows all file types. </value>
    [DataMember(Name="file_types_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_types_mode")]
    public string FileTypesMode { get; set; }

    /// <summary>
    /// (file) The type of files allowed to be uploaded if the `file_type_option` is set to `specific`. Values:   `images` - Allows upload of image MIME types (`bmp`, `gif`, `jpg`, `jpeg`, `jpe`, `jif`, `jfif`, `jfi`, `png`, `wbmp`, `xbm`, `tiff`). `documents` - Allows upload of document MIME types (`txt`, `pdf`, `rtf`, `doc`, `docx`, `xls`, `xlsx`, `accdb`, `mdb`, `one`, `pps`, `ppsx`, `ppt`, `pptx`, `pub`, `odt`, `ods`, `odp`, `odg`, `odf`).   `other` - Allows file types defined in the `file_types_other` array. 
    /// </summary>
    /// <value>(file) The type of files allowed to be uploaded if the `file_type_option` is set to `specific`. Values:   `images` - Allows upload of image MIME types (`bmp`, `gif`, `jpg`, `jpeg`, `jpe`, `jif`, `jfif`, `jfi`, `png`, `wbmp`, `xbm`, `tiff`). `documents` - Allows upload of document MIME types (`txt`, `pdf`, `rtf`, `doc`, `docx`, `xls`, `xlsx`, `accdb`, `mdb`, `one`, `pps`, `ppsx`, `ppt`, `pptx`, `pub`, `odt`, `ods`, `odp`, `odg`, `odf`).   `other` - Allows file types defined in the `file_types_other` array. </value>
    [DataMember(Name="file_types_supported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_types_supported")]
    public List<string> FileTypesSupported { get; set; }

    /// <summary>
    /// (file) A list of other file types allowed with the file upload option. 
    /// </summary>
    /// <value>(file) A list of other file types allowed with the file upload option. </value>
    [DataMember(Name="file_types_other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_types_other")]
    public List<string> FileTypesOther { get; set; }

    /// <summary>
    /// (file) The maximum size for a file that can be used with the file upload option. This will still be limited by the server. 
    /// </summary>
    /// <value>(file) The maximum size for a file that can be used with the file upload option. This will still be limited by the server. </value>
    [DataMember(Name="file_max_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_max_size")]
    public int? FileMaxSize { get; set; }

    /// <summary>
    /// (text, multi_line_text) Flag to validate the length of a text or multi-line text input. 
    /// </summary>
    /// <value>(text, multi_line_text) Flag to validate the length of a text or multi-line text input. </value>
    [DataMember(Name="text_characters_limited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_characters_limited")]
    public bool? TextCharactersLimited { get; set; }

    /// <summary>
    /// (text, multi_line_text) The minimum length allowed for a text or multi-line text option. 
    /// </summary>
    /// <value>(text, multi_line_text) The minimum length allowed for a text or multi-line text option. </value>
    [DataMember(Name="text_min_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_min_length")]
    public int? TextMinLength { get; set; }

    /// <summary>
    /// (text, multi_line_text) The maximum length allowed for a text or multi line text option. 
    /// </summary>
    /// <value>(text, multi_line_text) The maximum length allowed for a text or multi line text option. </value>
    [DataMember(Name="text_max_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_max_length")]
    public int? TextMaxLength { get; set; }

    /// <summary>
    /// (multi_line_text) Flag to validate the maximum number of lines allowed on a multi-line text input. 
    /// </summary>
    /// <value>(multi_line_text) Flag to validate the maximum number of lines allowed on a multi-line text input. </value>
    [DataMember(Name="text_lines_limited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_lines_limited")]
    public bool? TextLinesLimited { get; set; }

    /// <summary>
    /// (multi_line_text) The maximum number of lines allowed on a multi-line text input. 
    /// </summary>
    /// <value>(multi_line_text) The maximum number of lines allowed on a multi-line text input. </value>
    [DataMember(Name="text_max_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_max_lines")]
    public int? TextMaxLines { get; set; }

    /// <summary>
    /// (numbers_only_text) Flag to limit the value of a number option. 
    /// </summary>
    /// <value>(numbers_only_text) Flag to limit the value of a number option. </value>
    [DataMember(Name="number_limited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_limited")]
    public bool? NumberLimited { get; set; }

    /// <summary>
    /// (numbers_only_text) The type of limit on values entered for a number option. 
    /// </summary>
    /// <value>(numbers_only_text) The type of limit on values entered for a number option. </value>
    [DataMember(Name="number_limit_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_limit_mode")]
    public string NumberLimitMode { get; set; }

    /// <summary>
    /// (numbers_only_text) The lowest allowed value for a number option if `number_limited` is true. 
    /// </summary>
    /// <value>(numbers_only_text) The lowest allowed value for a number option if `number_limited` is true. </value>
    [DataMember(Name="number_lowest_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_lowest_value")]
    public decimal? NumberLowestValue { get; set; }

    /// <summary>
    /// (numbers_only_text) The highest allowed value for a number option if `number_limited` is true. 
    /// </summary>
    /// <value>(numbers_only_text) The highest allowed value for a number option if `number_limited` is true. </value>
    [DataMember(Name="number_highest_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_highest_value")]
    public decimal? NumberHighestValue { get; set; }

    /// <summary>
    /// (numbers_only_text) Flag to limit the input on a number option to whole numbers only. 
    /// </summary>
    /// <value>(numbers_only_text) Flag to limit the input on a number option to whole numbers only. </value>
    [DataMember(Name="number_integers_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_integers_only")]
    public bool? NumberIntegersOnly { get; set; }

    /// <summary>
    /// (product_list, product_list_with_images) Flag for automatically adjusting inventory on a product included in the list. 
    /// </summary>
    /// <value>(product_list, product_list_with_images) Flag for automatically adjusting inventory on a product included in the list. </value>
    [DataMember(Name="product_list_adjusts_inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_list_adjusts_inventory")]
    public bool? ProductListAdjustsInventory { get; set; }

    /// <summary>
    /// (product_list, product_list_with_images) Flag to add the optional product's price to the main product's price. 
    /// </summary>
    /// <value>(product_list, product_list_with_images) Flag to add the optional product's price to the main product's price. </value>
    [DataMember(Name="product_list_adjusts_pricing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_list_adjusts_pricing")]
    public bool? ProductListAdjustsPricing { get; set; }

    /// <summary>
    /// (product_list, product_list_with_images) How to factor the optional product's weight and package dimensions into the shipping quote. Values: `none` - don't adjust; `weight` - use shipping weight only; `package` - use weight and dimensions. 
    /// </summary>
    /// <value>(product_list, product_list_with_images) How to factor the optional product's weight and package dimensions into the shipping quote. Values: `none` - don't adjust; `weight` - use shipping weight only; `package` - use weight and dimensions. </value>
    [DataMember(Name="product_list_shipping_calc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_list_shipping_calc")]
    public string ProductListShippingCalc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigFull1 {\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  CheckedByDefault: ").Append(CheckedByDefault).Append("\n");
      sb.Append("  CheckboxLabel: ").Append(CheckboxLabel).Append("\n");
      sb.Append("  DateLimited: ").Append(DateLimited).Append("\n");
      sb.Append("  DateLimitMode: ").Append(DateLimitMode).Append("\n");
      sb.Append("  DateEarliestValue: ").Append(DateEarliestValue).Append("\n");
      sb.Append("  DateLatestValue: ").Append(DateLatestValue).Append("\n");
      sb.Append("  FileTypesMode: ").Append(FileTypesMode).Append("\n");
      sb.Append("  FileTypesSupported: ").Append(FileTypesSupported).Append("\n");
      sb.Append("  FileTypesOther: ").Append(FileTypesOther).Append("\n");
      sb.Append("  FileMaxSize: ").Append(FileMaxSize).Append("\n");
      sb.Append("  TextCharactersLimited: ").Append(TextCharactersLimited).Append("\n");
      sb.Append("  TextMinLength: ").Append(TextMinLength).Append("\n");
      sb.Append("  TextMaxLength: ").Append(TextMaxLength).Append("\n");
      sb.Append("  TextLinesLimited: ").Append(TextLinesLimited).Append("\n");
      sb.Append("  TextMaxLines: ").Append(TextMaxLines).Append("\n");
      sb.Append("  NumberLimited: ").Append(NumberLimited).Append("\n");
      sb.Append("  NumberLimitMode: ").Append(NumberLimitMode).Append("\n");
      sb.Append("  NumberLowestValue: ").Append(NumberLowestValue).Append("\n");
      sb.Append("  NumberHighestValue: ").Append(NumberHighestValue).Append("\n");
      sb.Append("  NumberIntegersOnly: ").Append(NumberIntegersOnly).Append("\n");
      sb.Append("  ProductListAdjustsInventory: ").Append(ProductListAdjustsInventory).Append("\n");
      sb.Append("  ProductListAdjustsPricing: ").Append(ProductListAdjustsPricing).Append("\n");
      sb.Append("  ProductListShippingCalc: ").Append(ProductListShippingCalc).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
