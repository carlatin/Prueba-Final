#!/usr/bin/env Python
# -*- coding: utf-8 -*-
#def factura():
import webbrowser
def historia()
def ubicacion():
	webbrowser.open("https://www.google.com/maps/place/Metro+Nte.,+Guatemala/@14.6477112,-90.4808864,17z/data=!3m1!4b1!4m5!3m4!1s0x8589a29aaeecf82b:0xcf3b17d29e9017ef!8m2!3d14.647706!4d-90.4786977")
def productos():
	prod={"Iphone":2000,"Iphonex":2500,"Iphoney":2900,"Samsung Galaxy j2":900,"Samsung Galaxy j4":1600,"Samsung Galaxy j6":1800,"Samsung Galaxy j7":2000}
	cont=0
	for x in prod:
		cont=cont+1
		print str(cont)+"  " + x + "  Q."+str(prod[x])
	comprar=raw_input("Desea comprar algo _______________")
	if comprar =="si":
		compra=raw_input("Que desea adquirir____________ ")
		nombre=raw_input("Inserte nombre del comprador___________")
		nit=input("inserte el Nit del compredor___________")
		dire=raw_input("inserte su direccion___________")
		productSelect = {}
		print"**************************************"
		print"               FACTURA                       "
		print"**************************************"
		print "               "+nombre+"                "
		print "            "+str(nit)+"                  "
		print "            "+dire+"               "
		print ""
		print " PRODUCTO             "+"      VALOR         "
		print compra +"                       "+str(prod[compra])
		print "TOTAL_______________________ "+str(prod[compra])
	else:
		print "gracias"

def menu():
	print """
		********************************************
				App  Magic
		********************************************

		1.Que somos ?
		2.Productos 
		3.Ubicacion 
		"""
	r=input("Inserte el numero de opcion que desee -----    ")
	if r==2:
		productos()
	elif r==3:
		ubicacion()
	elif r==1:
		historia()
menu()