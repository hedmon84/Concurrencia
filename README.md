# Concurrencia



#DB Diagram


#End Points 1

| URL         | Param       | Description |  Retorno     |
| ----------- | ----------- |  -----      |  ----------- |
| https://localhost:44369/api/Destinations   | none            |   Retorna la lista de los destinos disponibles          |      [
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
                                                                                  },                            |

----------------------------------------------------------

#End Points 2


| URL         | Param       | Description |  Retorno     |
| ----------- | ----------- |  -----      |  ----------- |
|https://localhost:44369/api/{place}/{date}/{date2}/{price}/{internet}    | none            |    Retorna el Destino con el filtro especificado.         |      |[
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
                                                                                  },                         |


------------------------------------------------------------------------------------------------------------------------------------------------
                                                                                  

