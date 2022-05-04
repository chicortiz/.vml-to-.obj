# desenvolvimento incremental
#
import xml.etree.ElementTree as ET
car = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.vml'
mytree = ET.parse(car)
myroot = mytree.getroot()

# lista os vertices
for vertex in myroot[2][0][0]:
    print(vertex.text.split())

# lista os poligonos
for polygon in myroot[2][0][1]:
    print(polygon.text.split())

# lista os poligonos renumerando os vertices

# grava o arquivo obj.

