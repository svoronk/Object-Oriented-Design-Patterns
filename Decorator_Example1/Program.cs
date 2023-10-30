using System;

// Component (TextEditor)
interface ITextEditor
{
    string Write();
}

// Concrete Component (BasicTextEditor)
class BasicTextEditor : ITextEditor
{
    public string Write()
    {
        return "Basic text.";
    }
}

// Decorator (TextDecorator)
abstract class TextDecorator : ITextEditor
{
    protected ITextEditor textEditor;

    public TextDecorator(ITextEditor editor)
    {
        textEditor = editor;
    }

    public virtual string Write()
    {
        return textEditor.Write();
    }
}

// Concrete Decorators
class BoldTextDecorator : TextDecorator
{
    public BoldTextDecorator(ITextEditor editor) : base(editor) { }

    public override string Write()
    {
        string baseText = base.Write();
        return "<b>" + baseText + "</b>";
    }
}

class ItalicTextDecorator : TextDecorator
{
    public ItalicTextDecorator(ITextEditor editor) : base(editor) { }

    public override string Write()
    {
        string baseText = base.Write();
        return "<i>" + baseText + "</i>";
    }
}

class Program
{
    static void Main()
    {
        ITextEditor basicEditor = new BasicTextEditor();
        Console.WriteLine("Basic Text: " + basicEditor.Write());

        ITextEditor boldEditor = new BoldTextDecorator(basicEditor);
        Console.WriteLine("Bold Text: " + boldEditor.Write());

        ITextEditor italicEditor = new ItalicTextDecorator(basicEditor);
        Console.WriteLine("Italic Text: " + italicEditor.Write());

        ITextEditor boldItalicEditor = new BoldTextDecorator(italicEditor);
        Console.WriteLine("Bold Italic Text: " + boldItalicEditor.Write());
    }
}
