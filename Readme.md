## Hot keys

* Ctrl+J : Intellisense 
* Ctrl+K, L : List members
* Ctrl+K, P: Show function parameter information
* ALT+ENTER = CTRL + .

## Code Snippets

Use code snippets to append codes into editor quickly.


## Visual Studio 2017 New features
1. Collection initialization can be simplized

![](assets/001.png)

![](assets/002.png)



## C# 6.0
1. [Expression bodied method](http://www.kunal-chowdhury.com/2014/12/csharp-6-expression-bodied-method.html#XYqZPss7xFduvydL.97)

2. Null validation

```
//if(obj!=null)
//  obj.Print();

obj?.Print();
```

3. using static 

```
using static System.Console;

void main()
{
    //Replace Console.WriteLine("xxxxxx")
    WriteLine("xxxxxx");
}
```


## C# 7.0
1. [Local function](https://www.infoworld.com/article/3182416/application-development/c-7-in-depth-exploring-local-functions.html)

2. [Out variable](http://www.c-sharpcorner.com/article/out-variables-in-c-sharp-7-0/)

3. Propfull

```
private string _name = string.Empty;
private DateTime _modiftOn { get; set; } = DateTime.Now;
public String Name {
    get => this._name;
    set { this._name = value; }
}
```


## C# Type

1. Value
2. Reference



## Generic

`System.Collections.Generic.List` includes
* `List<T>`
* `Queue<T>`
* `Stack<T>`

1. ArrayList as List
2. HashTable as Dictionary


## Class 

It's a reference type and Class can define 
* field
* method
* property
* event

### Inherit

Any class which doesn't inherit any parent class, will inherit `Object` in default. 


### Virtual

* [了解使用 Override 和 New 關鍵字的時機](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords)


### Type convertion

1. `As` will return null while convert fails
2. `()` will throw exception while convert fails

> `typeof` : takes a type name (which you specify at compile time).
>
> `GetType` :  gets the runtime type of an instance.
>
> `is` : returns true if an instance is in the inheritance tree.


Reference:
* [Type Checking: typeof, GetType, or is?](https://stackoverflow.com/a/983061/7045253)


## Constructor & Finalize

* Constructor calling anothoer one
```
public Book():this("暫無名稱")
{

}

public Book(string name)
{
    this._name = name;
}
```

* Do not call the finalize when already disposed

```
~Account()
{
    Console.WriteLine("Finalize!");
}

public void Dispose()
{
    Console.WriteLine("Dispose!");
    GC.SuppressFinalize(this); //CLR wont call the finalizer
}
```