# -*-coding: utf-8-*-

_PL_PERFIL_TEMPLATE = {
  "displayFieldName": "",
  "fieldAliases": {
    "CODI": "CODI",
    "HOJA": "HOJA",
    "DESCRIP": "DESCRIP",
    "CUADRANTE": "CUADRANTE",
    "CODHOJA": "CODHOJA",
    "ETIQUETA": "ETIQUETA"
  },
  "geometryType": "esriGeometryPolyline",
  "fields": [
    {
      "name": "CODI",
      "type": "esriFieldTypeSmallInteger",
      "alias": "CODI",
      "length": 5
    },
    {
      "name": "HOJA",
      "type": "esriFieldTypeString",
      "alias": "HOJA",
      "length": 4
    },
    {
      "name": "CUADRANTE",
      "type": "esriFieldTypeString",
      "alias": "CUADRANTE",
      "length": 1
    },
    {
      "name": "CODHOJA",
      "type": "esriFieldTypeString",
      "alias": "CODHOJA",
      "length": 4
    },
    {
      "name": "ETIQUETA",
      "type": "esriFieldTypeString",
      "alias": "ETIQUETA",
      "length": 100
    },
    {
      "name": "DESCRIP",
      "type": "esriFieldTypeString",
      "alias": "DESCRIP",
      "length": 60
    }
  ]
}


_PT_LEYENDA_TEMPLATE_MHG = {
  "displayFieldName": "",
  "fieldAliases": {
    "OBJECTID": "OBJECTID",
    "etiqueta": "etiqueta",
    "tipo": "tipo",
    "id_mapa": "id_mapa"
  },
  "geometryType": "esriGeometryPoint",
  "fields": [
    {
      "name": "OBJECTID",
      "type": "esriFieldTypeOID",
      "alias": "OBJECTID"
    },
    {
      "name": "etiqueta",
      "type": "esriFieldTypeString",
      "alias": "etiqueta",
      "length": 500
    },
    {
      "name": "tipo",
      "type": "esriFieldTypeString",
      "alias": "tipo",
      "length": 50
    },
    {
      "name": "id_mapa",
      "type": "esriFieldTypeString",
      "alias": "id_mapa",
      "length": 50
    }
  ]
}

_PO_LEYENDA_TEMPLATE_MHG = {
  "displayFieldName": "",
  "fieldAliases": {
    "OBJECTID": "OBJECTID",
    "id_mapa": "id_mapa",
    "SHAPE_Length": "SHAPE_Length",
    "SHAPE_Area": "SHAPE_Area"
  },
  "geometryType": "esriGeometryPolygon",
  "fields": [
    {
      "name": "OBJECTID",
      "type": "esriFieldTypeOID",
      "alias": "OBJECTID"
    },
    {
      "name": "tipo",
      "type": "esriFieldTypeString",
      "alias": "descrip",
      "length": 50
    },
    {
      "name": "id_mapa",
      "type": "esriFieldTypeString",
      "alias": "id_mapa",
      "length": 50
    },
    {
      "name": "SHAPE_Length",
      "type": "esriFieldTypeDouble",
      "alias": "SHAPE_Length"
    },
    {
      "name": "SHAPE_Area",
      "type": "esriFieldTypeDouble",
      "alias": "SHAPE_Area"
    }
  ]
}