This application includes these features;

- User registration

- User login

- Create to-do list. Each user will be able to have multiple to-do lists. Each to-do list will have a name.

- List of to-do lists.

- Delete to-do list

- Add to-do item to existing to-do list.

- Add dependency between to-do items. To-do items which have dependency can not be completed if dependent to-do item is not completed.

- Each to-do item should have a name, description, deadline, and status.

- Mark to-do item as "Complete".

- Filter to-do items (status complete or not, expired, name) on a to-do list

- Order to-do items on a to-do list by  deadline, name, or status.

- Delete to-do item from to-do list.


Client Side:
  It is an ASP.NET core application that implemented in Visual Studio.
  Used libraries;
  1.Restsharp
  2.Newtonsoft.json
  3.Jquery
  4.Bootstrap
  
  You must change IPv4 Address from StaticVariables.Url.
  For learning your IPv4 address open command line and write "ipconfig" then enter.
  (http://Your_IPv4_Adress:8080/)
  
 Server Side:
  It is a restful api implemented with spring boot framework in intellij.
  It uses embedded HyperSQL and hibernate library.
  
