# Concurrencia



#DB Diagram



| Syntax      | Description | Retorno | 
| ----------- | ----------- |  -----  |
| https://localhost:44369/api/Destinations     | Title       |         |
| Paragraph   | Text        |         |



#End Points

   |     URL                                     |  Param |                     Retorno                                      |  Descripción                                         

1 .| https://localhost:44369/api/Destinations     | none    |[
                                                                                  {
                                                                                      "name": "United State",
                                                                                      "cities": [
                                                                                          {
                                                                                              "name": "Los Angeles",
                                                                                              "countryId": 1,
                                                                                              "nearActivities": [],
                                                                                              "places": [],
                                                                                              "id": 1
                                                                                          }
                                                                                      ],
                                                                                      "id": 1
                                                                                  },
                                                                                  {
                                                                                      "name": "Honduras",
                                                                                      "cities": [
                                                                                          {
                                                                                              "name": "San Pedro Sula",
                                                                                              "countryId": 2,
                                                                                              "nearActivities": [],
                                                                                              "places": [],
                                                                                              "id": 2
                                                                                          }
                                                                                      ],
                                                                                      "id": 2
                                                                                  },                                           | Retorna la lista de los destinos disponibles.|
                                                                                  
                                                                                  
                                                                                  
2 .| https://localhost:44369/api/{place}/{date}/{date2}/{price}/{internet}     | none    | [{
                                                                                      "name": "Honduras",
                                                                                      "cities": [
                                                                                          {
                                                                                              "name": "San Pedro Sula",
                                                                                              "countryId": 2,
                                                                                              "nearActivities": [],
                                                                                              "places": [],
                                                                                              "id": 2
                                                                                          }
                                                                                      ],
                                                                                      "id": 2
                                                                                  },              ]                | Retorna el Destino con el filtro especificado.|
