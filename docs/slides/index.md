# Efficient data fetching
using **ASP.NET Core** and **GraphQL**  
[www.involved-it.be](https://www.involved-it.be)



# { REST }


<h2><i class="fa fa-server fa-2x"></i></h2>
```C#
public class ShoppingCartController : ApiController
{
    // GET: api/checkout
    public Cart Get()
    {
        return new Cart{
            TotalAmount = 25439,
            Items = [
                ItemUrl1,
                // ...
                ItemUrl99
            ]
        };
    }
}
```


<h2><i class="fa fa-laptop fa-2x"></i></h2>
```http
HTTP GET /api/checkout
HTTP GET /api/items/1
...
HTTP GET /api/items/99
```


<h2><i class="fa fa-server fa-2x"></i></h2>
```C#
public class ShoppingCartController : ApiController
{
    // GET: api/myCustomCheckout
    public Cart Get()
    {
        return new Cart{
            TotalAmount = 25439,
            Items = [
                Item1,
                // ...
                Item99
            ]
        };
    }
}
```


<h2><i class="fa fa-laptop fa-2x"></i></h2>
```http
HTTP GET /api/myCustomCheckout
```


<h2><i class="fa fa-mobile fa-2x"></i></h2>
```http
HTTP GET /api/myCustomCheckout
```


<h5><i class="fa fa-spinner fa-spin fa-5x"></i></h5>


<h2><i class="fa fa-server fa-2x"></i></h2>
```C#
public class ShoppingCartController : ApiController
{
    // GET: api/myCustomCheckoutForMobile
    public Cart Get()
    {
        return new Cart{
            TotalAmount = 25439,
            Items = [
                MobileItem1,
                // ...
                MobileItem99
            ]
        };
    }
}
```


<h2>
<i class="fa fa-mobile fa-3x"></i>
<i class="fa fa-tablet fa-3x"></i>
<i class="fa fa-laptop fa-3x"></i>
<i class="fa fa-desktop fa-3x"></i>
</h2>


<h1>
<i class="fa fa-question-circle fa-3x"></i>
</h1>



<h1>
<img class="no-border" src="img/icon-graphql.svg" width="500px" height="500px">
</h1>


## SERVER


## CLIENT


## CLIENTS



<h2><i class="material-icons mi-x5">question_answer</i></h2>