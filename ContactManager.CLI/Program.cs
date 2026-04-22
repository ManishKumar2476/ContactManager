using ContactManager.Core;
using ContactManager.CLI;

return
   new Menu(
       new SystemConsole(),
       new ContactService(new InMemoryContactRepository()))
       .Run();

