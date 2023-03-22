using Microsoft.AspNetCore.Mvc;

namespace ecohacks.Server.Controllers;

[ApiController]
[Route("Search")]
public class SearchController : ControllerBase
{
    [HttpPost]
    [Route("NewItem")]
    public ActionResult Stf([FromBody] string searchQuery)
    {
        List<string> results = _products.Where(str => str.Contains(searchQuery)).ToList();
        return Ok(results);
    }

    private readonly string[] _products = {
        "https://www.libertytabletop.com/product-category/flatware/",
        "https://www.libertytabletop.com/product-category/chests-storage/",
        "https://www.libertytabletop.com/product-category/cookware/",
        "https://www.libertytabletop.com/product-category/bakeware/",
        "https://www.libertytabletop.com/product-category/dinnerware/",
        "https://www.libertytabletop.com/product-category/kitchen-tools-accessories/",
        "https://www.libertytabletop.com/product-category/liberty-tabletop-glassware/",
        "https://www.libertytabletop.com/product-category/cutting-boards/",
        "https://baggu.com/collections/reusable-bags",
        "https://us.whogivesacrap.org/products/100-recycled-toilet-paper-jumbo-rolls?clickref=1101lw9hsgRf&utm_source=affiliate&utm_medium=partner&utm_campaign=earthfriendlytips&utm_content=https://earthfriendlytips.com/",
        "https://www.amazon.com/dp/B0843D1FLB?ascsubtag=AwEAAAAAAAAAAcqY&linkCode=gs2&tag=thewire0f-20&th=1 ",
        "https://www.amazon.ca/Printworks-Percent-Recycled-Multipurpose-00018/dp/B007JJDTFI/ref=asc_df_B007JJDTFI/?tag=googleshopc0c-20&linkCode=df0&hvadid=292918129806&hvpos=&hvnetw=g&hvrand=10462374422525299888&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9000587&hvtargid=pla-304860422870&th=1",
        "https://us.whogivesacrap.org/products/forest-friendly-tissues-12-boxes?clickref=1100lw98cDKV&utm_source=affiliate&utm_medium=partner&utm_campaign=earthfriendlytips&utm_content=https://earthfriendlytips.com/",
        "https://us.whogivesacrap.org/products/forest-friendly-paper-towels-double-length-rolls",
        "https://us.whogivesacrap.org/products/premium-100-bamboo-toilet-paper-double-length-rolls",
        "https://food52.com/shop/products/7224-goodbye-detergent-kitchen-scrubs?sku=22427&clickref=1101lj7w26Xu&utm_source=partnerize&utm_medium=affiliate&clickref=1011lw9U6dgJ&utm_source=partnerize&utm_medium=affiliate",
        "https://www.amazon.ca/dp/B07JGCBWF6?slotNum=0&ots=1&ascsubtag=[artid%7C2089.g.1435[src%7C[ch%7C[lt%7C&linkCode=gg2&imprToken=94c182c5-93e0-e22f-94a&tag=bp_links-20",
        "https://www.amazon.ca/dp/B082LPCF4M?slotNum=1&ots=1&ascsubtag=[artid%7C2089.g.1435[src%7C[ch%7C[lt%7C&linkCode=gg2&imprToken=94c182c5-93e0-e22f-94a&tag=bp_links-20",
        "https://www.amazon.ca/s?k=Stasher+STSU01A+Silicone+Reusable%2C+Stand-Up+Mid+%28Clear%29+%7C+Food+Meal+Prep+Storage+Container+%7C+Lunch%2C+Travel%2C+Makeup%2C+Gym+Bag+%7C+Freezer%2C+Oven%2C+Microwave%2C+Dishwasher+Safe%2C+Leakproof&ascsubtag=%5Bartid%7C2089.g.1435%5Bsrc%7C%5Bch%7C%5Blt%7C&imprToken=94c182c5-93e0-e22f-94a&linkCode=gg3&tag=bp_links-20",
        "https://www.amazon.ca/dp/B006LWR2RU?slotNum=3&ots=1&ascsubtag=[artid%7C2089.g.1435[src%7C[ch%7C[lt%7C&linkCode=gg2&imprToken=94c182c5-93e0-e22f-94a&tag=bp_links-20 ",
        "https://www.amazon.ca/dp/B09GFG5PSM?slotNum=4&ots=1&ascsubtag=%5Bartid%7C2089.g.1435%5Bsrc%7C%5Bch%7C%5Blt%7C&linkCode=gg2&imprToken=94c182c5-93e0-e22f-94a&tag=bp_links-20&th=1",
        "https://www.avocadogreenmattress.com/products/green-natural-organic-mattress?irclickid=X74yfA2KDxyNUtAwvGwGi3gDUkDRqJxuuVd7V00&irgwc=1&utm_medium=affiliate&utm_source=impact&utm_campaign=10078",
        "https://packagefreeshop.com/products/reusable-ear-swab/?variant=39416791695457&irclickid=X:VyYkWXgxyIUXTzH0VWsUnYUkGTl33KE09MQM0&irgwc=1&utm_source=Impact&utm_campaign=Online%20Tracking%20Link&utm_medium=10078&irclickid=Xa80lG2KDxyNTnD1nLwv1wfYUkDRqJxGuVd7V00&irgwc=1&utm_source=Impact&utm_campaign=Skimbit%20Ltd.&utm_medium=mediapartner",
        "https://www.misfitsmarket.com/?exp=autoship&irclickid=Sxhzsw2KDxyNTnD1nLwv1wfYUkDRqJxOuVd7V00&irgwc=1&utm_source=impact&utm_medium=affiliate-middle&utm_campaign=10078",
        "https://packagefreeshop.com/products/zero-waste-kit-dish-cleaning",
        "https://packagefreeshop.com/products/package-free-titanium-toothpicks/",
        "https://packagefreeshop.com/products/stainless-steel-straight-straws-silver-4-pack/",
        "https://packagefreeshop.com/products/glass-and-bamboo-food-container/?variant=39639324229729",
        "https://packagefreeshop.com/products/package-free-wooden-soap-dish/",
        "https://packagefreeshop.com/products/produce-bag-bundle-cotton/",
        "https://packagefreeshop.com/products/package-free-shampoo-bar/?variant=39825674272865",
        "https://packagefreeshop.com/products/package-free-conditioner-bar/?variant=39825674371169",
        "https://packagefreeshop.com/products/stainless-steel-bent-straws-silver-4-pack/",
        "https://packagefreeshop.com/products/earth-polish-cleanser/",
        "https://packagefreeshop.com/products/tremella-toning-mist/?variant=39817932537953",
        "https://packagefreeshop.com/products/premium-reusable-bamboo-cutlery-set/",
        "https://packagefreeshop.com/products/package-free-reusable-food-storage-wrap/",
        "https://packagefreeshop.com/collections/shop-all-pet"
    };
}