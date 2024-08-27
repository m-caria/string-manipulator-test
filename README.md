# STRING MANIPULATOR TEST

## 1. Shoes discount

**Q.** What's the output of the following code? Why?

**A.** The output of the program that applying the discount is ‘my shoes 100’ because, due to the way the ApplyDiscount function is structured, the product properties are not updated.
In order to apply the discount with the ApplyDiscount method, we have several options including:

**1. Using the keyword ref:**

```csharp
static void ApplyDiscount(ref Product product)
{
  product = new() { Name = "discounted shoes", Price = product.Price / 2 }
}

Product shoes = new() { Name = "my shoes", Price = 100 };
ApplyDiscount(ref shoes);
Console.WriteLine(shoes.ToString());
```

Using the keyword ref, the parameter reference is passed to the method.

**2. Returning the updated product:**

```csharp
static Product ApplyDiscount(Product product)
	=> new() { Name = "discounted shoes", Price = product.Price / 2 };

Product shoes = new() { Name = "my shoes", Price = 100 };
shoes = ApplyDiscount(shoes);
Console.WriteLine(shoes.ToString());
```

In this way the ApplyDiscount method will directly return the updated value.

## 2. String Manipulator

Using the C# language, have the program take the string parameter being passed and return the
largest word in the string. If there are two or more words that are the same length, return the
first word from the string with that length. Ignore punctuation and assume string will not be
empty.
Expose the feature as Web API endpoint returning JSON and as MVC Action that returns HTML
containing the result. Keep the program open for future extension allowing different string
manipulation algorithm (shortest word for example).

General rules

- Code runs all the test
- Code does not contain duplication
- Code is expressive
- Code is small
- Code adheres to SOLID principles
