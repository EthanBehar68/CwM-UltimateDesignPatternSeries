namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public interface RedoableCommand : UndoableCommand
    {
        public void RedoExecute();
    }
}