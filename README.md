# MappingTable

We've all come accross `switch` statements that shouldn't exist. They can often be refactored in a more object oriented manner. In some other cases, one would simply convert `switches` into a Dictionary. However `switch` statements do allow a default cases whereas Dictionaries don't.

Writing a wrapper around Dictionaries is rather trivial. This one is published as a nuget package in order to allow easy reuse accross projects.

## Usage

Initialize a MappingTable<TKey, TValue> object as follow:

```cs
var mapping = new Gen.MappingTable<string, Func<string>>()
{
    Mapping =
    {
        { "arbitrary-key", () => "arbitrary-value" }
    },
    Default = () => "default-value"
};
```

And use it like a regular Dictionary:

Func<string> existingValue = mapping["arbitrary-key"]; // Key exists. The associated value is returned: () => "arbitrary-value"
Func<string> defaultValue = mapping["some-unknown-key"]; // Key not found. The default value is returned: () => "default-value"

## License

This project is licensed under the terms of the MIT license.