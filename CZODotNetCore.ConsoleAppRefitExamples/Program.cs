using CZODotNetCore.ConsoleAppRefitExamples;
using Refit;

//var service = RestService.For<IBlogApi>("https://localhost:7156");
//var lst = await service.GetBlogs();

//foreach (var item in lst)
//{
//    Console.WriteLine($"Title=>{item.BlogTitle}");
//}

//try
//{
//    RefitExample refitExample = new RefitExample();
//    await refitExample.RunAsync();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

RefitExample refitExample = new RefitExample();
await refitExample.RunAsync();