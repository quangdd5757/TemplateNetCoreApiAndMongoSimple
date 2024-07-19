Web Api MongoDB
# Giới thiệu
- đây là tài liệu mẫu nhằm khởi tạo 1 project mới
- project này phát triển trên nền tàng ASP.NET core 6.0, nhằm khởi tạo server API kết nối tới database MongoDB

# môi trường
- ASP.NET core 6.0 API
- MongoDB.Driver

# hướng dẫn chi tiết (từ nguồn [link](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-8.0&tabs=visual-studio]))
1. khởi tạo project ASP.NET core API mẫu
2. install package MongoDB.Driver
```
Install-Package MongoDB.Driver
```
3. add model Book
4. add CRUD service
5. add controller

# Config Json serialization
- default
```
{
    "id": "666913f40741dbaf5b1ed12c",
    "Name": "book name 1 1",
    "price": 11,
    "category": "story 1",
    "author": "quang 1"
}
```
- Camel Casing
```
builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
```
```
{
    "Id": "666913f40741dbaf5b1ed12c",
    "Name": "book name 1 1",
    "Price": 11,
    "Category": "story 1",
    "Author": "quang 1"
}
```