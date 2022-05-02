import xml.etree.ElementTree as ET
fn = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/ParseXML/Sample.xml'
car = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.vml'
mytree = ET.parse(car)
myroot = mytree.getroot()