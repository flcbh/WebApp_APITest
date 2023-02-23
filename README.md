 
# Web API Test

This is a simple API that I made as a test and demonstration of my knowledge of software development using the .Net Platform.

This API was built to my understanding of the requirements, as there was no form of validation.

# Requirements

257483 - Full Stack Lead .Net Software Developer

Thank you for your application for the above vacancy. We would like to progress you to the next stage of the recruitment process, which is our technical test. 

The goal of the technical test is to demonstrate the following DDaT technical skills: prototyping, modern standards approach, and programming and build. Your solution will be used to assess these skills, and if you are subsequently invited to interview, your approach will be discussed during the interview.

Please only spend enough time to demonstrate your technical abilities, creating a prototype solution using a core set of technologies. Your solution should be accompanied with a minimal set of appropriate tests.

Please submit your completed solution by 23:59 on Friday 24th Feb 2023.

Submission process:
  - Add your solution to a private repo in your personal Github account
  - Invite the following Github user as a collaborator to the repo: steve-dickinson
  - Email to confirm when this is done: ddtsonpayrollrecruitment@defra.gov.uk

The Task:

Using C# and .Net 6 create an API that combines data from two APIs from the Defra Data Services Platform:
  - Assets: https://environment.data.gov.uk/asset-management/doc/reference
  - Flood Monitoring: https://environment.data.gov.uk/flood-monitoring/doc/reference

Both the assets and flood APIs can search by longitude/latitude and a radius/distance.

The task is to provide a single API endpoint that accepts the ID of a flood monitoring station and a radius, and returns the maintained asset IDs within that radius.

A RESTful API should be created that returns JSON for a GET endpoint with the following URL structure: https://<URL>/{station-id}/asset?radius={radius}

Note that the station ID is part of the URL path, while the radius is a query string. Only the Asset IDs should be returned from the API, no other information is needed.

Ensure the edge cases of the APIs are handled correctly and suitable HTTP response codes are returned.

Please consider your approach to clean coding and testing when composing your solution.

The submission should be documented in the README.md with instructions on launching the project and running tests. The accepted input and return types and response codes of the newly created API should also be documented.

You may find the following endpoints useful for your solution:
  - List all flood monitoring stations, where you can find their ids: https://environment.data.gov.uk/flood-monitoring/id/stations
  - Get information (including its latitude and longitude) for a single station based on its ID (in this case 1491TH): https://environment.data.gov.uk/flood-monitoring/id/stations/1491TH
  - List the maintained assets (including their IDs) within the given radius of a given latitude and longitude: https://environment.data.gov.uk/asset-management/maintained-asset.geojson?lat=51.756247&lng=-1.238765&radius=5


## API Reference

#### Test all items

```
  Test Browse https://localhost:7143/swagger/index.html
```

#### Get items

```
  GET https://localhost:7143/api/Values/1029TH/5}
```


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `radius`  | `string` | **Required**. Radius to fetch     |

#### Get(string1, string2)

Takes Assets and Monitoring


## Feedback

A test case was developed using Unit that can also be used to test the API.


## Deployment

To deploy this project open with

```.net
  Visual Studio 2022 - c# 6.0
```


## Authors

- Frank Coelho
- Flcbh@hotmail.com
