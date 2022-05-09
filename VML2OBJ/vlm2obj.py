car = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.vml'
carobj = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/car.obj'
building = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/Building.vml'
buildingobj = '/home/omy/Documentos/Programming/Python/ClubedeLeitura/VML2OBJ/Building.obj'

def vml2obj(fin, fout):
    # parse vml file into a tree.
    import xml.etree.ElementTree as ET
    mytree = ET.parse(fin)
    myroot = mytree.getroot()
    
    # prepare to write to file
    fobj = open(fout, 'w')

    # lista os vertices preparando a conversão
    iVertex = 0 # contator de vertices
    VertexDicio = dict()
    for vertex in myroot[2][0][0]:
        VertexNum, VertexX, VertexY, VertexZ = vertex.text.split()
        fobj.write('v ' +  str(VertexX) + ' ' +  str(VertexY) + ' ' + str(VertexZ) + '\n')
        iVertex += 1
        VertexDicio[VertexNum] = iVertex

    # lista as faces com os vertices renumerados
    for face in myroot[2][0][1]:
        aface = face.text.split()
        fobj.write('f ')
        for vertice in aface:
            if vertice != '4294967295': # investigar estes casos!
                fobj.write(str(VertexDicio[vertice]) + ' ')
        fobj.write('\n')

    # conclui a gravação
    fobj.close()
    



