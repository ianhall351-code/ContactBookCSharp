using Xunit;
using ContactBook;

namespace ContactBook.Tests;

public class ContactTests
{
    // -------------------------
    // Constructor Tests
    // -------------------------

    [Fact]
    public void Constructor_Default_AllFieldsEmpty()
    {
        var contact = new Contact();

        Assert.Equal("", contact.GetFName());
        Assert.Equal("", contact.GetLName());
        Assert.Equal("", contact.GetPhone());
        Assert.Equal("", contact.GetEmail());
    }

    [Fact]
    public void Constructor_WithAllParameters_SetsAllFields()
    {
        var contact = new Contact("John", "Doe", "555-1234", "john@email.com");

        Assert.Equal("John", contact.GetFName());
        Assert.Equal("Doe", contact.GetLName());
        Assert.Equal("555-1234", contact.GetPhone());
        Assert.Equal("john@email.com", contact.GetEmail());
    }

    [Fact]
    public void Constructor_WithOnlyFName_SetsOnlyFName()
    {
        var contact = new Contact(fname: "John");

        Assert.Equal("John", contact.GetFName());
        Assert.Equal("", contact.GetLName());
        Assert.Equal("", contact.GetPhone());
        Assert.Equal("", contact.GetEmail());
    }

    [Fact]
    public void Constructor_WithPartialParameters_SetsCorrectFields()
    {
        var contact = new Contact("Jane", "Smith");

        Assert.Equal("Jane", contact.GetFName());
        Assert.Equal("Smith", contact.GetLName());
        Assert.Equal("", contact.GetPhone());
        Assert.Equal("", contact.GetEmail());
    }

    // -------------------------
    // Getter Tests
    // -------------------------

    [Fact]
    public void GetFName_ReturnsCorrectValue()
    {
        var contact = new Contact(fname: "Alice");
        Assert.Equal("Alice", contact.GetFName());
    }

    [Fact]
    public void GetLName_ReturnsCorrectValue()
    {
        var contact = new Contact(lname: "Smith");
        Assert.Equal("Smith", contact.GetLName());
    }

    [Fact]
    public void GetPhone_ReturnsCorrectValue()
    {
        var contact = new Contact(phone: "787-555-0000");
        Assert.Equal("787-555-0000", contact.GetPhone());
    }

    [Fact]
    public void GetEmail_ReturnsCorrectValue()
    {
        var contact = new Contact(email: "alice@example.com");
        Assert.Equal("alice@example.com", contact.GetEmail());
    }

    // -------------------------
    // Setter Tests
    // -------------------------

    [Fact]
    public void SetFName_UpdatesFirstName()
    {
        var contact = new Contact(fname: "John");
        contact.SetFName("Jane");
        Assert.Equal("Jane", contact.GetFName());
    }

    [Fact]
    public void SetLName_UpdatesLastName()
    {
        var contact = new Contact(lname: "Doe");
        contact.SetLName("Smith");
        Assert.Equal("Smith", contact.GetLName());
    }

    [Fact]
    public void SetPhone_UpdatesPhone()
    {
        var contact = new Contact(phone: "000-0000");
        contact.SetPhone("787-123-4567");
        Assert.Equal("787-123-4567", contact.GetPhone());
    }

    [Fact]
    public void SetEmail_UpdatesEmail()
    {
        var contact = new Contact(email: "old@email.com");
        contact.SetEmail("new@email.com");
        Assert.Equal("new@email.com", contact.GetEmail());
    }

    [Fact]
    public void SetFName_ToEmptyString_AllowsIt()
    {
        var contact = new Contact(fname: "John");
        contact.SetFName("");
        Assert.Equal("", contact.GetFName());
    }

    // -------------------------
    // ToString Tests
    // -------------------------

    [Fact]
    public void ToString_WithAllFields_ReturnsCorrectFormat()
    {
        var contact = new Contact("John", "Doe", "555-1234", "john@email.com");
        var expected = "Contact[fname=John, lname=Doe, phone=555-1234, email=john@email.com]";
        Assert.Equal(expected, contact.ToString());
    }

    [Fact]
    public void ToString_WithDefaultValues_ReturnsEmptyFields()
    {
        var contact = new Contact();
        var expected = "Contact[fname=, lname=, phone=, email=]";
        Assert.Equal(expected, contact.ToString());
    }

    [Fact]
    public void ToString_AfterUpdate_ReflectsNewValues()
    {
        var contact = new Contact("John", "Doe", "555-1234", "john@email.com");
        contact.SetFName("Jane");
        Assert.Contains("fname=Jane", contact.ToString());
    }

    // -------------------------
    // Equals(Contact?) Tests
    // -------------------------

    [Fact]
    public void Equals_SameValues_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.True(c1.Equals(c2));
    }

    [Fact]
    public void Equals_DifferentFName_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("Jane", "Doe", "555-1234", "john@email.com");
        Assert.False(c1.Equals(c2));
    }

    [Fact]
    public void Equals_DifferentLName_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Smith", "555-1234", "john@email.com");
        Assert.False(c1.Equals(c2));
    }

    [Fact]
    public void Equals_DifferentPhone_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "000-0000", "john@email.com");
        Assert.False(c1.Equals(c2));
    }

    [Fact]
    public void Equals_DifferentEmail_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "555-1234", "other@email.com");
        Assert.False(c1.Equals(c2));
    }

    [Fact]
    public void Equals_Null_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.False(c1.Equals(null));
    }

    [Fact]
    public void Equals_SameReference_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.True(c1.Equals(c1));
    }

    // -------------------------
    // Equals(object?) Tests
    // -------------------------

    [Fact]
    public void Equals_Object_SameValues_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        object c2 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.True(c1.Equals(c2));
    }

    [Fact]
    public void Equals_Object_DifferentType_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        object other = "not a contact";
        Assert.False(c1.Equals(other));
    }

    [Fact]
    public void Equals_Object_Null_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.False(c1.Equals((object?)null));
    }

    // -------------------------
    // Operator == and != Tests
    // -------------------------

    [Fact]
    public void OperatorEquals_SameValues_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.True(c1 == c2);
    }

    [Fact]
    public void OperatorEquals_DifferentValues_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("Jane", "Doe", "555-1234", "john@email.com");
        Assert.False(c1 == c2);
    }

    [Fact]
    public void OperatorEquals_BothNull_ReturnsTrue()
    {
        Contact? c1 = null;
        Contact? c2 = null;
        Assert.True(c1 == c2);
    }

    [Fact]
    public void OperatorEquals_OneNull_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Contact? c2 = null;
        Assert.False(c1 == c2);
        Assert.False(c2 == c1);
    }

    [Fact]
    public void OperatorNotEquals_DifferentValues_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("Jane", "Doe", "555-1234", "john@email.com");
        Assert.True(c1 != c2);
    }

    [Fact]
    public void OperatorNotEquals_SameValues_ReturnsFalse()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.False(c1 != c2);
    }

    [Fact]
    public void OperatorNotEquals_OneNull_ReturnsTrue()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Contact? c2 = null;
        Assert.True(c1 != c2);
    }

    // -------------------------
    // GetHashCode Tests
    // -------------------------

    [Fact]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("John", "Doe", "555-1234", "john@email.com");
        Assert.Equal(c1.GetHashCode(), c2.GetHashCode());
    }

    [Fact]
    public void GetHashCode_DifferentValues_ReturnsDifferentHash()
    {
        var c1 = new Contact("John", "Doe", "555-1234", "john@email.com");
        var c2 = new Contact("Jane", "Doe", "555-1234", "john@email.com");
        Assert.NotEqual(c1.GetHashCode(), c2.GetHashCode());
    }

    [Fact]
    public void GetHashCode_AfterMutation_ChangesHash()
    {
        var contact = new Contact("John", "Doe", "555-1234", "john@email.com");
        var hashBefore = contact.GetHashCode();
        contact.SetFName("Jane");
        var hashAfter = contact.GetHashCode();
        Assert.NotEqual(hashBefore, hashAfter);
    }

    // -------------------------
    // Theory / Data-Driven Tests
    // -------------------------

    [Theory]
    [InlineData("Alice", "Wonder", "787-000-0001", "alice@wonder.com")]
    [InlineData("Bob", "Builder", "787-000-0002", "bob@build.com")]
    [InlineData("", "", "", "")]
    [InlineData("OnlyFirst", "", "", "")]
    public void Constructor_Theory_SetsFieldsCorrectly(string fname, string lname, string phone, string email)
    {
        var contact = new Contact(fname, lname, phone, email);

        Assert.Equal(fname, contact.GetFName());
        Assert.Equal(lname, contact.GetLName());
        Assert.Equal(phone, contact.GetPhone());
        Assert.Equal(email, contact.GetEmail());
    }

    [Theory]
    [InlineData("Alice", "Wonder", "787-000-0001", "alice@wonder.com")]
    [InlineData("Bob", "Builder", "787-000-0002", "bob@build.com")]
    public void Equals_Theory_SymmetricEquality(string fname, string lname, string phone, string email)
    {
        var c1 = new Contact(fname, lname, phone, email);
        var c2 = new Contact(fname, lname, phone, email);

        Assert.True(c1.Equals(c2));
        Assert.True(c2.Equals(c1));
    }
}