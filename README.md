# SaselaniKatas

In the interest of better understanding NSubstitute, write a character copier class that reads characters from a source and copies them to a destination. It must copy and write one character at a time.

To do this create a Copier class that takes in a ISource and IDestination. ISource has one method char ReadChar()​ and IDestination has one method void WriteChar(char c). ​ The Copier class has one method void Copy() ​ that when called reads from the ISource one character at a time and write to IDestination as seen in Figure 1 below.

The copying and writing is done character at a time until a newline (‘\n’) is encountered. Then the processing stops without writing the newline. Only the Copier class may exist as a concrete. You are to use NSubstitute to implement ISource and IDestination.



# Bonus
Once you have a single character working add a new method to both the ISource and IDestination that take will read and write multiple characters at a time. E.g. ReadChars(int count), WriteChars(char[] values). Be mindful not to read beyond the newline when copying between source and destination.
