//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace OneSpanSign.API
{
	
	
	internal class ViewSettings
	{
		
		// Fields
		
		// Accessors
		    
    [JsonProperty("layout")]
    public LayoutOptions Layout
    {
                get; set;
        }
    
		    
    [JsonProperty("style")]
    public LayoutStyle Style
    {
                get; set;
        }
    
		
	
	}
}