// functia ce converteste doar orele la doua locatii geografice
function convertTime() {
  const inputTime = document.getElementById("inputTime").value;
  const inputHour = parseInt(inputTime.split(":")[0]);
  const inputMinute = parseInt(inputTime.split(":")[1]);

  const fromCity = document.getElementById("fromCity").value;
  const toCity = document.getElementById("toCity").value;

  const fromOffset = cities.find(city => city.city === fromCity).offset;
  const toOffset = cities.find(city => city.city === toCity).offset;

  const totalMinutesOffsetFrom = fromOffset * 60;
  const totalMinutesOffsetTo = toOffset * 60;

  const currentTimeInFromCity = new Date();
  currentTimeInFromCity.setUTCHours(inputHour - fromOffset, inputMinute, 0, 0);

  const convertedTimeInToCity = new Date(currentTimeInFromCity.getTime() + totalMinutesOffsetTo * 60 * 1000);

  const hours = convertedTimeInToCity.getUTCHours().toString().padStart(2, '0');
  const minutes = convertedTimeInToCity.getUTCMinutes().toString().padStart(2, '0');
  const timeString = `${hours}:${minutes}`;

  document.getElementById("outputTime").textContent = `Ora în ${toCity}: ${timeString}`;
}

// Functia care calculeaza data si ora la 2 locatii geografice
function convertDateTime() {
  const inputDateTime = document.getElementById("inputDateTime").value;
  const [inputDate, inputTime] = inputDateTime.split("T");
  const [year, month, day] = inputDate.split("-");
  const [hour, minute] = inputTime.split(":");

  const fromCity = document.getElementById("fromCityDateTime").value;
  const toCity = document.getElementById("toCityDateTime").value;

  const fromOffset = cities.find(city => city.city === fromCity).offset;
  const toOffset = cities.find(city => city.city === toCity).offset;

  const fromDateTime = new Date(Date.UTC(year, month - 1, day, hour - fromOffset, minute));
  const convertedDateTime = new Date(fromDateTime.getTime() + (toOffset) * 60 * 60 * 1000);

  const convertedYear = convertedDateTime.getUTCFullYear();
  const convertedMonth = (convertedDateTime.getUTCMonth() + 1).toString().padStart(2, '0');
  const convertedDay = convertedDateTime.getUTCDate().toString().padStart(2, '0');
  const convertedHour = convertedDateTime.getUTCHours().toString().padStart(2, '0');
  const convertedMinute = convertedDateTime.getUTCMinutes().toString().padStart(2, '0');

  const convertedDateTimeString = `${convertedDay}-${convertedMonth}-${convertedYear} ${convertedHour}:${convertedMinute}`;

  document.getElementById("outputDateTime").textContent = `Data și ora în ${toCity}: ${convertedDateTimeString}`;
}
