# https://www.edureka.co/blog/python-xml-parser-tutorial/
import xml.etree.ElementTree as ET
fn = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/ParseXML/Sample.xml'
car = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.vml'
mytree = ET.parse(car)
myroot = mytree.getroot()

'/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml'

mytree = ET.parse('sample.xml') <--- Não tem o caminho completo dá "No such file"

mytree = ET.parse('/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml')

myroot = mytree.getroot()

#############

'/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml'
mytree = ET.parse('/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml')
myroot = mytree.getroot()
print(myroot)

Isso roda direto no Shell! Não foi necessário passar linha por linha!

Teste:

import xml.etree.ElementTree as ET
mytree = ET.parse('/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml')
myroot = mytree.getroot()
print(myroot)


>>> import xml.etree.ElementTree as ET
mytree = ET.parse('/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml')
myroot = mytree.getroot()
print(myroot)
<Element 'metadata' at 0x7fc434d42778>

<-- Dá certo também!

#############

Firefox e Chrome fazem um display da raiz do .xml com expandir e retrair, similar ao outliner do Blender 3D.

Chrome faz um display bem simples do .vml, somennte como texto, sem possiblidade de expandir e retrair.

Já o firefox faz um display de expandir e retrair mas é muito lento. 

Usando o car.vml como teste.

#############

what does 0x033589F0 means?
ChatGPT
The value "0x033589F0" is a hexadecimal representation of a number. In hexadecimal notation, the prefix "0x" is often used to indicate that the following characters represent a hexadecimal value.

Converting "0x033589F0" to decimal form, we get the value 54119600. Hexadecimal numbers are base-16, meaning they use 16 digits to represent values from 0 to 15. The digits used in hexadecimal are 0-9 for values 0-9 and A-F for values 10-15. Therefore, in "0x033589F0," each digit represents a power of 16, from right to left.

Breaking down "0x033589F0":

The rightmost digit "0" represents 0 * 16^0, which is 0 in decimal.
The next digit "F" represents 15 * 16^1, which is 240 in decimal.
The next digit "9" represents 9 * 16^2, which is 2304 in decimal.
The leftmost digit "3" represents 3 * 16^3, which is 12288 in decimal.
Adding up these decimal values, we get 12288 + 2304 + 240 + 0 = 54119600.

Therefore, "0x033589F0" is equivalent to the decimal value 54119600.

#############

what is hexadecimal?
ChatGPT
Hexadecimal is a number system that uses a base-16 representation. It is often used in computing and digital systems as a convenient way to represent binary data.

In the decimal system (base-10), we use 10 digits from 0 to 9. In hexadecimal, we use 16 digits: 0-9 for values 0-9, and A-F for values 10-15. The letters A, B, C, D, E, and F represent the decimal values 10, 11, 12, 13, 14, and 15, respectively.

Hexadecimal notation is often prefixed with "0x" to indicate that the following characters represent a hexadecimal value. For example, "0x1F" represents the number 31 in decimal.

Hexadecimal is commonly used in various computing contexts, such as:

Memory addresses: Memory addresses in computer systems are often represented in hexadecimal form.

Color representation: Hexadecimal values are used to represent colors in HTML, CSS, and other digital graphics systems. For example, #FF0000 represents the color red.

Binary representation: Hexadecimal is frequently used to represent binary data, such as machine code instructions or memory dumps. Each hexadecimal digit corresponds to four bits (half a byte) of binary data.

Hexadecimal is useful because it provides a compact representation of binary data and allows for easier conversion between binary and hexadecimal representations.

#############

what is a memory dump?
ChatGPT
A memory dump, also known as a core dump or system dump, refers to the process of copying the contents of a computer's volatile memory (RAM) to a storage medium, such as a disk or file. It captures a snapshot of the system's memory at a specific point in time, typically when an abnormal condition or system crash occurs.

A memory dump is often performed in situations where the system encounters a critical error, such as a software or hardware failure, or when diagnosing and troubleshooting system crashes or software bugs. It allows software developers, system administrators, or technical support personnel to analyze the state of the system's memory at the time of the incident.

By examining the memory dump, experts can investigate the cause of the issue, identify problematic software modules, detect memory leaks, analyze the state of data structures, or search for patterns that indicate errors or vulnerabilities. Memory dumps are particularly valuable in debugging complex software problems and identifying the root causes of system failures.

Memory dumps are typically stored in a binary format that represents the entire or a portion of the system's memory. Specialized debugging tools and software utilities can analyze these dumps, extract relevant information, and provide insights into the problem or crash that occurred.

It's important to note that memory dumps may contain sensitive information, such as passwords, encryption keys, or personal data. Therefore, when handling memory dumps, it's crucial to follow appropriate security protocols and ensure that sensitive data is protected.

############

import xml.etree.ElementTree as ET
mytree = ET.parse('car.vml')
myroot = mytree.getroot()
print(myroot)

############

>>> import xml.etree.ElementTree as ET
mytree = ET.parse('car.vml')
myroot = mytree.getroot()
print(myroot)
<Element 'vml' at 0x7fb5ad33c4f8>
>>> print <v>1</v>
  File "<pyshell>", line 1
    print <v>1</v>
               ^
SyntaxError: Missing parentheses in call to 'print'. Did you mean print(<v>1</v>)?

>>> print (<v>1</v>)
  File "<pyshell>", line 1
    print (<v>1</v>)
           ^
SyntaxError: invalid syntax

############

Trauma 1 : numa prova de matemática não há "meio certo".

Trauma 2 : quem é incapaz de lidar com números é incapaz de lidar com dinheiro; logo está condenado a ser um marginal.

###########

>>> import xml.etree.ElementTree as ET
mytree = ET.parse('/home/ortiz/Desktop/ClubeDeLeituraPython/PythonParsingTutorial/sample.xml')
myroot = mytree.getroot()
print(myroot)
<Element 'metadata' at 0x7fb5ad2eee58>
>>> 	
print(myroot[0].tag)
food
>>> for x in myroot[0]:
     print(x.tag, x.attrib)

#############

Como iniciar dois binários do Thonny de maneira independente? ---> Thonny options ---> General ---> Untick: [X] Allow only single Thonny instance 

#############

>>> import xml.etree.ElementTree as ET
mytree = ET.parse('car.xml')
myroot = mytree.getroot()
print(myroot)
<Element 'vml' at 0x7f4f25f44598>
>>> print(myroot.attrib)
{'version': '1.0'}
>>> print(myroot[0].tag)
node-object
>>> for x in myroot[0]:
     print(x.tag, x.attrib)

transform {}
links {}

##########

>>> for x in myroot[0]:
        print(x.text)
        

		

		
>>> for x in myroot[0]:
        print(v.text)
        
Traceback (most recent call last):
  File "<pyshell>", line 2, in <module>
NameError: name 'v' is not defined
>>> for x in myroot[0]:
        print(<v>.text)
        
  File "<pyshell>", line 2
    print(<v>.text)
          ^
SyntaxError: invalid syntax

>>> for x in myroot[0]:
        print(<v>1.text)
        
  File "<pyshell>", line 2
    print(<v>1.text)
          ^
SyntaxError: invalid syntax

>>> for x in myroot[0]:
        print(vertex.text)

Traceback (most recent call last):
  File "<pyshell>", line 2, in <module>
NameError: name 'vertex' is not defined
>>> for x in myroot[0]:
        print("vertex".text)
        
Traceback (most recent call last):
  File "<pyshell>", line 2, in <module>
AttributeError: 'str' object has no attribute 'text'
>>> for x in myroot.findall('tvr-geo'):
    vertex =x.find("vertex").text
    print(vertex)
    
>>> 
>>> 
>>> 
>>> 

##########

O que seria x neste caso exatamente? Um dummy?

##########

>>> import xml.etree.ElementTree as ET

tree = ET.parse(r"car.vml")
root = tree.getroot()

tag_list =["vertex"]

for elem in root.iter():
    if elem.tag in tag_list:
        print(elem.text)

<--- Roda e não aparece nada...

########

>>> import xml.etree.ElementTree as ET
car = '/home/ortiz/Desktop/ClubeDeLeituraPython/car.vml'
mytree = ET.parse(car)
myroot = mytree.getroot()
>>> 
>>> myroot print "vertex"
  File "<pyshell>", line 1
    myroot print "vertex"
               ^
SyntaxError: invalid syntax

>>> myroot "vertex"
  File "<pyshell>", line 1
    myroot "vertex"
                  ^
SyntaxError: invalid syntax

>>> 

Log de estudo do tutorial Edureka e tentativa de paralelo.

Revendo o video de reunião com Yasuda, creio que não é necessário mudar a listagem das faces conforme le propõe se os vértices forem corrigidos conforme o meu algoritmo.






