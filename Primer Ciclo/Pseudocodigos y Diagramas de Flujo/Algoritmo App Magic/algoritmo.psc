Algoritmo sin_titulo
	Definir tel,codigo,nit,cont,op Como Entero
	Definir ap,salario,nombr,apellido,direc,producto Como Caracter
	Definir texto Como Real
	Escribir "-------------------------------------"
	Escribir "'				App Magic			   '"
	Escribir "-------------------------------------"
	Escribir '1. Informacion'
	Escribir '2. hubicacion'
	Escribir '3. Productos'
	Escribir "Que numero de opcion decea realizar ?  " 
	Leer op
	Segun op Hacer
		1:
			escribir "QUE SOMOS ?"
			escribir "Somos una empresa dedicada al funcionamiento mantenimiento y actualizacion de tecnologia"
			escribir "VISION"
			escribir "Ser el numero uno en tecnologiay estar en la vanguardia de ello"
			escribir "MISION"
			ESCRIBIR "Llevar la tecnologia a todo el mundo incluso a los lugares en donde no se conoce de la tecnologia"
		2:
			escribir "ESCUINTLA"
			escribir"Centro Comercial La Pradera Escuintla LOCAL 72B Escuintla, Guatemala"
			
			escribir "Tel: (502) 2328-0051"
			Escribir "Horario: Lunes a domingo 10:00 a 20:00"
			escribir "Sin cerrar al medio día"
			
		3:
			escribir "1. Iphone:		2000"
			escribir "2. Iphone xs:		5000"
			escribir "3. Iphone 6:		1500"
			escribir "4. Samsung s9:	5000"
			escribir "5. Huawei y9:		5000"
			Escribir "6. Desea adquirir algun producto ?"
			Leer ap
			Si ap="si" Entonces
				Escribir "AVISO SOLO EL PRIMER PRODUCTO PUEDE COMPRAR"
				Escribir "Que producto desea adquirir ?"
				leer pro 
				si pro = 1 Entonces
					Escribir "inserte sunombre"
					leer nombr
					escribir "inserte su direccion"
					leer direc
					escribir "inserte NIT"
					leer nit 
					Escribir "inserte numero celular"
					leer tel
					Escribir "_____________________________________________________"
					Escribir "------------------------------------------"
					Escribir "				Factura						"
					Escribir "------------------------------------------"
					escribir nombr
					Escribir direc
					Escribir nit
					Escribir tel
					Escribir "-------------------------------------------"
					Escribir "  PRODUCTO________________________PRECIO   "
					Escribir "-------------------------------------------"
					Escribir "1. Iphone.......................Q 2000.00  "
					Escribir "   TOTAL........................q 2000.00  "
					Escribir "-------------------------------------------"
				FinSi
			Sino
				Escribir "GRACIAS POR SU VISITA"
			Fin Si
		De Otro Modo:
			escribir "Opcion invalida"
	Fin Segun
FinAlgoritmo

