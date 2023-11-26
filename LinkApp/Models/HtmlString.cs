namespace LinkApp.Models;

public class HtmlString
{
    public string Html { get; set; } = "";

    public string GetHtml()
    {
        return  $"""
                           <div class="card" style="display:table; padding: 1rem; border-radius:1rem;">
                          <div class="" style="display: table-row-group; padding: 1rem; border-radius: 1rem;">
                          <div class="" style="display: table-row;">
                          <div class="" style="display: table-cell; padding: 1rem;">
                                              Enter Link
                                                    </div>
                                                    </div>
                                                    <div class="" style="display: table-row;">
                                                    <div class="" style="display: table-cell; padding: 1rem;">
                                                    <input type="url" placeholder="URL" style="width:19rem;" @bind="newUrl"/>
                                                    </div>
                                                    <div class="" style="display: table-cell; padding: 1rem;">
                                                    <button type="button" @onclick="AddUrl">Add</button>
                                                    </div>
                                                    </div>
                                                    </div>
                                                    </div>
                          """;;
    }
}

