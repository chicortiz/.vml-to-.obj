import xml.etree.ElementTree as ET
car = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.vml'
mytree = ET.parse(car)
myroot = mytree.getroot()

# lista os vertices preparando a conversão
iVertex = 0 # contator de vertices
VertexDicio = dict()
for vertex in myroot[2][0][0]:
    VertexNum, VertexX, VertexY, VertexZ = vertex.text.split()
    iVertex += 1
    print('v ', VertexX, VertexY, VertexZ)
    VertexDicio[VertexNum] = iVertex

# lista as faces com os vertices renumerados
for face in myroot[2][0][1]:
    aface = face.text.split()
    print('f', end= ' ')
    for vertice in aface:
        if vertice != '4294967295': # investigar estes casos!
            print(VertexDicio[vertice], end=' ')
    print()

# grava o arquivo obj.




