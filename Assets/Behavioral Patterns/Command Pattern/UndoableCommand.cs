namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public interface UndoableCommand : Command
    {
        public void UndoExecute();
    }
}