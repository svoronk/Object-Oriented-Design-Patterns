using System;
using System.Collections.Generic;

// Component
interface IDocumentComponent
{
    void Display();
}

// Leaf: Sentence
class Sentence : IDocumentComponent
{
    private string text;

    public Sentence(string text)
    {
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine("Sentence: " + text);
    }
}

// Composite: Paragraph
class Paragraph : IDocumentComponent
{
    private List<IDocumentComponent> components = new List<IDocumentComponent>();

    public void AddComponent(IDocumentComponent component)
    {
        components.Add(component);
    }
    public void Display()
    {
        Console.WriteLine("Paragraph:");
        foreach (var component in components)
        {
            component.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create leaf components (sentences)
        IDocumentComponent sentence1 = new Sentence("This is the first sentence.");
        IDocumentComponent sentence2 = new Sentence("This is the second sentence.");

        // Create a composite component (paragraph)
        Paragraph paragraph = new Paragraph();
        paragraph.AddComponent(sentence1);
        paragraph.AddComponent(sentence2);

        // Display the paragraph (composite)
        paragraph.Display();
    }
}
