let serverUrl = 'https://catbrowser.onrender.com/api'

if (
  !process.env.NODE_ENV ||
  process.env.NODE_ENV === 'development' ||
  process.env.NODE_ENV === 'test'
) {
  serverUrl = 'http://localhost:5143/api'
} else {
  serverUrl = 'https://catbrowser.onrender.com/api'
}

export const axiosUrls = {
  getCatsUrl: `${serverUrl}/cats`,
  getCatUrl: `${serverUrl}/cats/`,
  removeCatUrl: `${serverUrl}/cats/`
}
